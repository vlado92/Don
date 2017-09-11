using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Drawing.Printing;

namespace Don
{
    public partial class Stanje : Form
    {
        SqlCeCommand command = new SqlCeCommand("", PocetnaForma.conn);
        SqlCeDataReader reader;
        double cijena = 0;

        public Stanje()
        {
            InitializeComponent();
        }
        private void StanjeSanka_Load(object sender, EventArgs e)
        {
            FillData();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            if (PocetnaForma.role == (int)PocetnaForma.TipRadnika.Admin)
            {
                Size = new Size(549, 350);
            }
            else
                Size = new Size(549, 315);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }
        private void artikalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();

            command.CommandText = "SELECT * FROM Artikal WHERE naziv = '" + artikalCombo.SelectedItem + "';";
            reader = command.ExecuteReader();
            reader.Read();

            naStanju.Text = "" + Double.Parse(reader.GetString(3));
            warningBound.Text = reader.GetString(5);
            PocetnaForma.conn.Close();
        }
        private void FillData()
        {
            cijena = 0;
            artikalCombo.Items.Clear();
            endOfDayList.Items.Clear();
            warningBound.Text = naStanju.Text = dodajArtikle.Text = 
                artikalCombo.Text = endOfDayList.Text = "";
            showPreview.Checked = false;
            if (PocetnaForma.role == (int)PocetnaForma.TipRadnika.Admin)
                showPreview.Visible = true;
            else
                showPreview.Visible = false;
            command.CommandText = "SELECT * FROM Artikal WHERE kombinacija < 0;";

            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                artikalCombo.Items.Add(reader.GetString(1));
            }
            string datum = "0000-00-00";
            command.CommandText = "SELECT COUNT(id) FROM Presjek_dana;";

            reader = command.ExecuteReader();
            reader.Read();
            if (reader.GetInt32(0) > 0)
            {
                command.CommandText = "SELECT vreme_presjeka FROM Presjek_dana WHERE id = " + (reader.GetInt32(0) - 1) + ";";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datum = PocetnaForma.convertDateTimeToDatabaseFormat(reader.GetDateTime(0));
                }
            }

            endOfDayList.Items.Add("Od " + datum + " je izdato:");
            SqlCeCommand newCommand = new SqlCeCommand("", PocetnaForma.conn);
            SqlCeDataReader newReader;
            SqlCeDataReader yetAnotherReader;

            command.CommandText = "SELECT id FROM Racun "
                    + " WHERE datum > '" + datum + "';";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.Out.WriteLine("prolazi kroz racun");
                newCommand.CommandText = "SELECT artikal_id, kolicina_artikla FROM racun_artikal "
                    + "WHERE racun_id = " + reader.GetInt32(0) + ";";
                newReader = newCommand.ExecuteReader();
                while (newReader.Read())
                {
                    Console.Out.WriteLine("prolazi kroz racun_artikal");
                    newCommand.CommandText = "SELECT Naziv, Cijena FROM Artikal WHERE id = " + newReader.GetInt32(0) + ";";
                    yetAnotherReader = newCommand.ExecuteReader();
                    while (yetAnotherReader.Read())
                    {
                        int indeks = -1;
                        for (int i = 0; i < endOfDayList.Items.Count; i++)
                            if (endOfDayList.Items[i].ToString().Contains(yetAnotherReader.GetString(0)))
                            {
                                indeks = i;
                                break;
                            }
                        if (indeks < 0)
                        {
                            endOfDayList.Items.Add(writeResult(yetAnotherReader.GetString(0),
                                PocetnaForma.ConvertDoubleToPrintFormat(newReader.GetString(1)),
                                PocetnaForma.ConvertDoubleToPrintFormat(yetAnotherReader.GetString(1)), 0));
                        }
                        else
                        {
                            string item = endOfDayList.Items[indeks].ToString();
                            double dosadasnjaCijena = Double.Parse(item.Substring(item.IndexOf(':') + 2, item.IndexOf('(') - item.IndexOf(':') - 3));
                            endOfDayList.Items[indeks] = writeResult(yetAnotherReader.GetString(0), PocetnaForma.ConvertDoubleToPrintFormat(newReader.GetString(1)), PocetnaForma.ConvertDoubleToPrintFormat(yetAnotherReader.GetString(1)), dosadasnjaCijena);
                        }
                        cijena += Double.Parse(newReader.GetString(1)) * Double.Parse(yetAnotherReader.GetString(1));
                    }
                }
            }
            endOfDayList.Items.Add("UKUPNI CEH: " + cijena);
            PocetnaForma.conn.Close();
        }
        private void FinishDayButton_Click(object sender, EventArgs e)
        {
            command.CommandText = "INSERT INTO presjek_dana(vreme_presjeka, kolicina) VALUES"
                + "('" + PocetnaForma.convertDateTimeToDatabaseFormat(DateTime.Now) + "', '" + cijena + "');";

            PocetnaForma.conn.Close();
            PocetnaForma.conn.Open();
            command.ExecuteNonQuery();
            PocetnaForma.conn.Close();
            printEndOfDay();

            FillData();
            MessageBox.Show("Unesen dan");
        }
        private void printEndOfDay()
        {
            string output = "";
            string[] firstRow = endOfDayList.Items[0].ToString().Split(' ');
            output = "Od " + firstRow[1] + " " + firstRow[2] + " do " + PocetnaForma.convertDateTimeToDatabaseFormat(DateTime.Now) + " je izdato:\n";
            int numberOfRows = 3;
            for (int i = 1; i < endOfDayList.Items.Count; i++, numberOfRows++)
            {
                if (endOfDayList.Items[i].ToString().Length > 30)
                    numberOfRows++;
                output += endOfDayList.Items[i] + "\n";
            }
            System.Drawing.Printing.PrintDocument print = new System.Drawing.Printing.PrintDocument();
            Graphics g = print.PrinterSettings.CreateMeasurementGraphics();
            Font myFont = new Font("Times New Roman", PocetnaForma.fontSize, FontStyle.Regular, GraphicsUnit.Millimeter);
            print.DefaultPageSettings.PaperSize = new PaperSize("moja", PocetnaForma.billWidth, (int)((numberOfRows + 2) * g.MeasureString("1", myFont).Height));
            Console.Out.WriteLine(output);
            print.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(output, myFont, new SolidBrush(Color.Black),
                    new RectangleF(0, 0, print.DefaultPageSettings.PrintableArea.Width,
                    print.DefaultPageSettings.PrintableArea.Height));
                float y = g.MeasureString("a", myFont).Height * (endOfDayList.Items.Count);
            };
            PrintPreviewDialog pdi = new PrintPreviewDialog();
            pdi.Document = print;
            if (showPreview.Checked)
            {
                TopMost = false;
                pdi.ShowDialog();
                TopMost = true;
            }
            try
            {
                if (printCheckBox.Checked)
                    print.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }

        }
        private void UpdateStockButton_Click(object sender, EventArgs e)
        {
            double broj;
            if (string.IsNullOrEmpty(artikalCombo.Text))
            {
                MessageBox.Show("GRESKA ARTICAL COMBO");
            }
            else if (string.IsNullOrEmpty(dodajArtikle.Text))
            {
                MessageBox.Show("GRESKA Dodaj artikal");
            }
            else if (!Double.TryParse(dodajArtikle.Text, out broj))
            {
            }
            else
            {
                PocetnaForma.conn.Close();
                PocetnaForma.conn.Open();
                command.CommandText = "SELECT Stanje, cijena FROM Artikal WHERE naziv = '" + artikalCombo.SelectedItem.ToString() + "';";
                reader = command.ExecuteReader();
                reader.Read();
                broj = Double.Parse(reader.GetString(0)) + double.Parse(dodajArtikle.Text);
                command.CommandText = "UPDATE Artikal SET stanje = '" + broj + "', upozorenje = '" + warningBound.Text + "' WHERE naziv = '" + artikalCombo.SelectedItem.ToString() + "';";
                command.ExecuteNonQuery();
                PocetnaForma.conn.Close();
                MessageBox.Show("Uneseno");
                FillData();
            }
        }
        string writeResult(string nazivArtikla, string novaKolicina, string cijenaArtikla, double staraKolicina)
        {
            return nazivArtikla + ": " + (staraKolicina + Double.Parse(novaKolicina)) + " (" + (Double.Parse(cijenaArtikla) * (Double.Parse(novaKolicina) + staraKolicina)) + ")";
        }
    }
}