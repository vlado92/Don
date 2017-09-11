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
    public partial class currerentStatus : Form
    {
        public currerentStatus()
        {
            InitializeComponent();
        }

        private void currerentStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donBazaDataSet.Artikal' table. You can move, or remove it, as needed.
            this.artikalTableAdapter.Fill(this.donBazaDataSet.Artikal);
       //     this.artikalTableAdapter.Fill(this.donBazaDataSet1.Artikal);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
        //        this.artikalTableAdapter.FillBy(this.donBazaDataSet.Artikal);
            }
            catch (System.Exception ex)
            {
               System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void artikalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void currerentStatus_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'donBazaDataSet.Artikal' table. You can move, or remove it, as needed.
            this.artikalTableAdapter.Fill(this.donBazaDataSet.Artikal);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
