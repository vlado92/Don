using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using Microsoft.VisualBasic;

namespace Don
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }
        private void potvrdi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(korisnickoText.Text))
            {
                MessageBox.Show("Unesite korisničko ime");
                korisnickoText.Focus();
            }
            else if (string.IsNullOrEmpty(sifraTekst.Text))
            {
                MessageBox.Show("Unesite šifru");
                sifraTekst.Focus();
            }
            else
            {
                SqlCeConnection conn = new SqlCeConnection(PocetnaForma.connString);
                SqlCeCommand command = new SqlCeCommand("SELECT * FROM Zaposleni "
                + " WHERE korisnicko = '" + korisnickoText.Text + "' AND "
                + " sifra = '" + PocetnaForma.HashNewPassword(sifraTekst.Text) + "';", conn);

                conn.Close();
                conn.Open();
                SqlCeDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PocetnaForma.userName =  reader.GetString(3) + " " + reader.GetString(4);
                    PocetnaForma.role = reader.GetInt32(5);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    korisnickoText.Clear();
                    sifraTekst.Clear();
                    MessageBox.Show("Niste unijeli ispravne podatke");
                    korisnickoText.Focus();
                }
            }
        }
        private void EnterClicked(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                potvrdi_Click(sender, e);
        }
    }
}
