using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace Don
{
    public partial class DodatneOpcije : Form
    {
        #region Form Functions
        SqlCeCommand command = new SqlCeCommand("", PocetnaForma.conn);
        public DodatneOpcije()
        {
            InitializeComponent();
            tipRadnika.SelectedIndex = jedinica.SelectedIndex =  0;
        }
        private void DodatneOpcije_Load(object sender, EventArgs e)
        {
            RemoveEmployeeComboBox.Items.Clear();
            if (PocetnaForma.role == (int)PocetnaForma.TipRadnika.Admin)
                tipRadnika.Items.Add("Admin");
            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();
            command.CommandText = "SELECT korisnicko FROM Zaposleni WHERE tip < 2;";
            SqlCeDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                RemoveEmployeeComboBox.Items.Add(reader.GetString(0));
            }
            PocetnaForma.conn.Close();
            RemoveEmployeeComboBox.SelectedIndex = -1;
            RemoveEmployeeComboBox.Text = "";
            ukloniIme.Clear();
            ukloniTipRadnika.Clear();
        }
        #endregion

        #region Insert/Remove Employee
        private void InsertEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ime.Text))
            {
                MessageBox.Show("Unesite ime čovjeka");
                ime.Focus();
            }
            else if (string.IsNullOrEmpty(prezime.Text))
            {
                MessageBox.Show("Unesite prezime čovjeka");
                prezime.Focus();
            }
            else if (string.IsNullOrEmpty(korisnicko.Text))
            {
                MessageBox.Show("Unesite korisničko ime");
                korisnicko.Focus();
            }
            else if (string.IsNullOrEmpty(sifraKorisnika.Text))
            {
                MessageBox.Show("Unesite šifru korisnika");
                sifraKorisnika.Focus();
            }
            else
            {
                command.CommandText = "SELECT COUNT(*) FROM Zaposleni WHERE korisnicko = '" + korisnicko.Text + "';";

                PocetnaForma.conn.Close();
                PocetnaForma.conn.Open();
                SqlCeDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.GetInt32(0) == 0)
                {
                    command.CommandText = "INSERT INTO Zaposleni(korisnicko, sifra, ime, prezime, tip)"
                       + " VALUES('" + korisnicko.Text + "', '" + PocetnaForma.HashNewPassword( sifraKorisnika.Text) + "', '"
                       + ime.Text + "', '" + prezime.Text + "', " + tipRadnika.SelectedIndex + ");";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Zaposleni unesen u bazu podataka");
                }
                else
                    MessageBox.Show("Korisnicko ime vec postoji");
                PocetnaForma.conn.Close();
                
                ime.Clear();
                prezime.Clear();
                korisnicko.Clear();
                sifraKorisnika.Clear();
                tipRadnika.SelectedIndex = 0;
            }
        }
        private void RemoveEmployeeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();
            command.CommandText = "SELECT * FROM Zaposleni WHERE korisnicko = '" + RemoveEmployeeComboBox.SelectedItem.ToString() + "';";
            SqlCeDataReader reader = command.ExecuteReader();
            reader.Read();
            ukloniIme.Text = reader.GetString(3) + " " + reader.GetString(4);
            if (reader.GetInt32(5) == 0)
                ukloniTipRadnika.Text = "Konobar";
            else
                ukloniTipRadnika.Text = "Šef";
            PocetnaForma.conn.Close();
        }
        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {

            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();
            command.CommandText = "DELETE FROM Zaposleni WHERE korisnicko = '" + RemoveEmployeeComboBox.SelectedItem.ToString() + "';";
            command.ExecuteNonQuery();
            PocetnaForma.conn.Close();
            MessageBox.Show("Radnik uklonjen");
            DodatneOpcije_Load(sender, e);
        }
        #endregion

        #region InsertItem
        private void InsertItemButton_Click(object sender, EventArgs e)
        {
            double broj;
            int integer;
            if (string.IsNullOrEmpty(nazivArtikla.Text))
            {
                MessageBox.Show("Unesite naziv artikla");
                nazivArtikla.Focus();
            }
            else if (string.IsNullOrEmpty(cijenaArtikla.Text) && !Double.TryParse(cijenaArtikla.Text, out broj))
            {
                MessageBox.Show("Unesite ispravno cijenu artikla");
                cijenaArtikla.Focus();
            }
            else if (string.IsNullOrEmpty(stanje.Text) && !Double.TryParse(stanje.Text, out broj))
            {
                MessageBox.Show("Unesite ispravno stanje");
                stanje.Focus();
            }
            else if (string.IsNullOrEmpty(minimum.Text) && !Double.TryParse(minimum.Text, out broj))
            {
                MessageBox.Show("Unesite na kojem stanju da Vas obavjesti");
                minimum.Focus();
            }
            else if (casaUFlasi.Visible && string.IsNullOrEmpty(casaUFlasi.Text) && !Int32.TryParse(casaUFlasi.Text, out integer))
            {
                MessageBox.Show("Unesite ispravno broj čaša po jednoj flaši pića\nNapomena: Prvo mora biti unijeto piće i broj čaša mora biti cijeli broj.");
                minimum.Focus();
            }
            else if (string.IsNullOrEmpty(sifraArtikla.Text) && !Int32.TryParse(sifraArtikla.Text, out integer))
            {
                MessageBox.Show("Unesite ispravno šifru.");
                minimum.Focus();
            }
            else
            {
                if (!casaUFlasi.Visible)
                    command.CommandText = "INSERT INTO Artikal(sifra, naziv, cijena, stanje, jedinica, upozorenje, casaUFlasi, kombinacija)"
                        + " VALUES('" + sifraArtikla.Text + "','" + nazivArtikla.Text + "', '" + cijenaArtikla.Text + "', '"
                        + stanje.Text + "', " + jedinica.SelectedIndex + ", " + minimum.Text + ", 1, -1);";
                else
                {
                    command.CommandText = "SELECT * FROM artikal WHERE naziv = '" + nazivArtikla.Text + "';";

                    PocetnaForma.conn.Close();
                    PocetnaForma.conn.Open();
                    SqlCeDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                        command.CommandText = "UPDATE Artikal SET casaUFlasi = " + Int32.Parse(casaUFlasi.Text)
                        + " WHERE naziv = '" + nazivArtikla.Text + "';";
                    else
                        command.CommandText = "INSERT INTO Artikal(sifra, naziv, cijena, stanje, jedinica, upozorenje, casaUFlasi, kombinacija)"
                        + " VALUES('" + sifraArtikla.Text + "', '" + nazivArtikla.Text + "', '" + (Double.Parse(cijenaArtikla.Text) * Int32.Parse(casaUFlasi.Text)).ToString() + "', '"
                        + stanje.Text + "', " + jedinica.SelectedIndex + ", " + minimum.Text + ", " + Int32.Parse(casaUFlasi.Text) + ", -1);";
                    PocetnaForma.conn.Close();
                }

                PocetnaForma.conn.Close();
                PocetnaForma.conn.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlCeException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
                PocetnaForma.conn.Close();
                MessageBox.Show("Artikal unesen u bazu podataka");
                nazivArtikla.Clear();
                cijenaArtikla.Clear();
                sifraArtikla.Clear();
                stanje.Clear();
                jedinica.SelectedIndex = 0;
                minimum.Clear();
                nazivArtikla.Focus();
            }
        }
        private void jedinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jedinica.SelectedIndex == 1)
            {
                casaUFlasiLabel.Visible = casaUFlasi.Visible = casaUFlasi.TabStop = true;
            }
            else
            {
                casaUFlasiLabel.Visible = casaUFlasi.Visible = casaUFlasi.TabStop = false;
            }
        }
        private void Float_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= '0' && e.KeyValue <= '9') || (e.KeyValue >= 96 && e.KeyValue <= 105) || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back)
            {}
            else if ((e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) && !((TextBox)sender).Text.Contains(','))
            {
                e.SuppressKeyPress = true;
                string text = ((TextBox)sender).Text;
                text += ',';
                ((TextBox)sender).Text = text;
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length; // add some logic if length is 0
                ((TextBox)sender).SelectionLength = 0;
            }
            else
                e.SuppressKeyPress = true;
        }
        private void Integer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= '0' && e.KeyValue <= '9') ||(e.KeyValue >= 96 && e.KeyValue <=105) || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back)
            { }
            else
                e.SuppressKeyPress = true;
        }
        #endregion
    }
}
