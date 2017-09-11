using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Don
{
    public partial class EnterPass : Form
    {
        public EnterPass()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Unesite šifru!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                string pass = PocetnaForma.HashNewPassword(textBox1.Text);
                System.Data.SqlServerCe.SqlCeDataReader reader = new System.Data.SqlServerCe.SqlCeCommand("SELECT id, tip  FROM Zaposleni WHERE sifra = '" + pass + "';", PocetnaForma.conn).ExecuteReader();
                if (reader.Read())
                {
                    if(PocetnaForma.role >= reader.GetInt32(1))
                    {
                        PocetnaForma.userCode = reader.GetInt32(0);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {                        
                        MessageBox.Show("Unesite šifru korisnika sa ispravnim odobrenjem!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Unesite ispravnu šifru!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                    textBox1.Clear();
                    textBox1.Focus();
                }

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
