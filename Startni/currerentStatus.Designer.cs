namespace Don
{
    partial class currerentStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(currerentStatus));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donBazaDataSet = new Startni.DonBazaDataSet();
            this.artikalTableAdapter = new Startni.DonBazaDataSetTableAdapters.ArtikalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donBazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.stanjeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSource;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // sifraDataGridViewTextBoxColumn
            // 
            this.sifraDataGridViewTextBoxColumn.DataPropertyName = "sifra";
            resources.ApplyResources(this.sifraDataGridViewTextBoxColumn, "sifraDataGridViewTextBoxColumn");
            this.sifraDataGridViewTextBoxColumn.Name = "sifraDataGridViewTextBoxColumn";
            this.sifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            resources.ApplyResources(this.nazivDataGridViewTextBoxColumn, "nazivDataGridViewTextBoxColumn");
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // stanjeDataGridViewTextBoxColumn
            // 
            this.stanjeDataGridViewTextBoxColumn.DataPropertyName = "Stanje";
            resources.ApplyResources(this.stanjeDataGridViewTextBoxColumn, "stanjeDataGridViewTextBoxColumn");
            this.stanjeDataGridViewTextBoxColumn.Name = "stanjeDataGridViewTextBoxColumn";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Artikal";
            this.bindingSource.DataSource = this.donBazaDataSet;
            // 
            // donBazaDataSet
            // 
            this.donBazaDataSet.DataSetName = "DonBazaDataSet";
            this.donBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artikalTableAdapter
            // 
            this.artikalTableAdapter.ClearBeforeFill = true;
            // 
            // currerentStatus
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "currerentStatus";
            this.Load += new System.EventHandler(this.currerentStatus_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donBazaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private Startni.DonBazaDataSet donBazaDataSet;
        private System.Windows.Forms.BindingSource bindingSource;
        private Startni.DonBazaDataSetTableAdapters.ArtikalTableAdapter artikalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanjeDataGridViewTextBoxColumn;
    }
}