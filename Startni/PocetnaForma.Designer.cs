namespace Don
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.sifraArtikla = new System.Windows.Forms.ComboBox();
            this.nazivArtikla = new System.Windows.Forms.ComboBox();
            this.potvrdi_unos = new System.Windows.Forms.Button();
            this.stanjeSanka = new System.Windows.Forms.Button();
            this.presjekTekst = new System.Windows.Forms.TextBox();
            this.presjek = new System.Windows.Forms.Button();
            this.upozorenja = new System.Windows.Forms.ListBox();
            this.dodatnoDugme = new System.Windows.Forms.Button();
            this.Gemišt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bambus = new System.Windows.Forms.Button();
            this.Bijelo_vino = new System.Windows.Forms.Button();
            this.Crno_vino = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.Ispis = new System.Windows.Forms.DataGridView();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.leftInStock = new System.Windows.Forms.Label();
            this.currerentStatus = new System.Windows.Forms.Button();
            this.Juice_Vodka = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.showPreview = new System.Windows.Forms.CheckBox();
            this.Kisela_voda = new System.Windows.Forms.Button();
            this.Vodka = new System.Windows.Forms.Button();
            this.Jagoda = new System.Windows.Forms.Button();
            this.Juice = new System.Windows.Forms.Button();
            this.Guarana = new System.Windows.Forms.Button();
            this.Nektar = new System.Windows.Forms.Button();
            this.Coca_cola = new System.Windows.Forms.Button();
            this.Heineken = new System.Windows.Forms.Button();
            this.red_bull = new System.Windows.Forms.Button();
            this.Jelen = new System.Windows.Forms.Button();
            this.Tuborg = new System.Windows.Forms.Button();
            this.printBillCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).BeginInit();
            this.SuspendLayout();
            // 
            // sifraArtikla
            // 
            this.sifraArtikla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sifraArtikla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sifraArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sifraArtikla.FormattingEnabled = true;
            this.sifraArtikla.Items.AddRange(new object[] {
            "55",
            "66"});
            this.sifraArtikla.Location = new System.Drawing.Point(72, 82);
            this.sifraArtikla.Name = "sifraArtikla";
            this.sifraArtikla.Size = new System.Drawing.Size(119, 32);
            this.sifraArtikla.TabIndex = 1;
            this.sifraArtikla.SelectedIndexChanged += new System.EventHandler(this.sifraArtikla_SelectedIndexChanged);
            // 
            // nazivArtikla
            // 
            this.nazivArtikla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nazivArtikla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nazivArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivArtikla.FormattingEnabled = true;
            this.nazivArtikla.Items.AddRange(new object[] {
            "Tuborg flasa",
            "Heineken flasa"});
            this.nazivArtikla.Location = new System.Drawing.Point(197, 82);
            this.nazivArtikla.Name = "nazivArtikla";
            this.nazivArtikla.Size = new System.Drawing.Size(209, 32);
            this.nazivArtikla.TabIndex = 0;
            this.nazivArtikla.SelectedIndexChanged += new System.EventHandler(this.nazivArtikla_SelectedIndexChanged);
            // 
            // potvrdi_unos
            // 
            this.potvrdi_unos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potvrdi_unos.Location = new System.Drawing.Point(725, 536);
            this.potvrdi_unos.Name = "potvrdi_unos";
            this.potvrdi_unos.Size = new System.Drawing.Size(271, 134);
            this.potvrdi_unos.TabIndex = 2;
            this.potvrdi_unos.Text = "Potvrdi unos";
            this.potvrdi_unos.UseVisualStyleBackColor = true;
            this.potvrdi_unos.Click += new System.EventHandler(this.potvrdi_unos_Click);
            // 
            // stanjeSanka
            // 
            this.stanjeSanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stanjeSanka.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stanjeSanka.Location = new System.Drawing.Point(725, 65);
            this.stanjeSanka.Name = "stanjeSanka";
            this.stanjeSanka.Size = new System.Drawing.Size(271, 46);
            this.stanjeSanka.TabIndex = 34;
            this.stanjeSanka.Text = "Stanje šanka";
            this.stanjeSanka.UseVisualStyleBackColor = true;
            this.stanjeSanka.Click += new System.EventHandler(this.BarInformation_Click);
            // 
            // presjekTekst
            // 
            this.presjekTekst.Enabled = false;
            this.presjekTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.presjekTekst.Location = new System.Drawing.Point(725, 171);
            this.presjekTekst.Name = "presjekTekst";
            this.presjekTekst.Size = new System.Drawing.Size(271, 38);
            this.presjekTekst.TabIndex = 41;
            this.presjekTekst.TabStop = false;
            this.presjekTekst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // presjek
            // 
            this.presjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.presjek.Location = new System.Drawing.Point(725, 117);
            this.presjek.Name = "presjek";
            this.presjek.Size = new System.Drawing.Size(271, 48);
            this.presjek.TabIndex = 40;
            this.presjek.Text = "Presjek stanja";
            this.presjek.UseVisualStyleBackColor = true;
            this.presjek.Click += new System.EventHandler(this.presjek_Click);
            // 
            // upozorenja
            // 
            this.upozorenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upozorenja.FormattingEnabled = true;
            this.upozorenja.ItemHeight = 24;
            this.upozorenja.Location = new System.Drawing.Point(725, 263);
            this.upozorenja.Name = "upozorenja";
            this.upozorenja.Size = new System.Drawing.Size(271, 172);
            this.upozorenja.TabIndex = 42;
            this.upozorenja.TabStop = false;
            // 
            // dodatnoDugme
            // 
            this.dodatnoDugme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodatnoDugme.Location = new System.Drawing.Point(15, 547);
            this.dodatnoDugme.Name = "dodatnoDugme";
            this.dodatnoDugme.Size = new System.Drawing.Size(228, 109);
            this.dodatnoDugme.TabIndex = 43;
            this.dodatnoDugme.TabStop = false;
            this.dodatnoDugme.Text = "Dugme dodatnih opcija";
            this.dodatnoDugme.UseVisualStyleBackColor = true;
            this.dodatnoDugme.Click += new System.EventHandler(this.BossButton_Click);
            // 
            // Gemišt
            // 
            this.Gemišt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gemišt.Location = new System.Drawing.Point(17, 228);
            this.Gemišt.Name = "Gemišt";
            this.Gemišt.Size = new System.Drawing.Size(106, 100);
            this.Gemišt.TabIndex = 47;
            this.Gemišt.TabStop = false;
            this.Gemišt.Text = "Gemišt";
            this.Gemišt.UseVisualStyleBackColor = true;
            this.Gemišt.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Artikal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(495, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Trenutni račun";
            // 
            // Bambus
            // 
            this.Bambus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bambus.Location = new System.Drawing.Point(349, 228);
            this.Bambus.Name = "Bambus";
            this.Bambus.Size = new System.Drawing.Size(104, 100);
            this.Bambus.TabIndex = 60;
            this.Bambus.TabStop = false;
            this.Bambus.Text = "Bambus";
            this.Bambus.UseVisualStyleBackColor = true;
            this.Bambus.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Bijelo_vino
            // 
            this.Bijelo_vino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bijelo_vino.Location = new System.Drawing.Point(127, 229);
            this.Bijelo_vino.Name = "Bijelo_vino";
            this.Bijelo_vino.Size = new System.Drawing.Size(104, 100);
            this.Bijelo_vino.TabIndex = 59;
            this.Bijelo_vino.TabStop = false;
            this.Bijelo_vino.Text = "Bijelo vino";
            this.Bijelo_vino.UseVisualStyleBackColor = true;
            this.Bijelo_vino.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Crno_vino
            // 
            this.Crno_vino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Crno_vino.Location = new System.Drawing.Point(237, 229);
            this.Crno_vino.Name = "Crno_vino";
            this.Crno_vino.Size = new System.Drawing.Size(104, 100);
            this.Crno_vino.TabIndex = 64;
            this.Crno_vino.TabStop = false;
            this.Crno_vino.Text = "Crno vino";
            this.Crno_vino.UseVisualStyleBackColor = true;
            this.Crno_vino.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(416, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 63);
            this.label4.TabIndex = 68;
            this.label4.Text = "Disco Bar Don";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(472, 82);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(214, 32);
            this.button16.TabIndex = 69;
            this.button16.Text = "Dodaj artikal na račun";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.dodajArtikal_Click);
            // 
            // Ispis
            // 
            this.Ispis.AllowUserToDeleteRows = false;
            this.Ispis.AllowUserToResizeColumns = false;
            this.Ispis.AllowUserToResizeRows = false;
            this.Ispis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Ispis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ispis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ispis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikal,
            this.Kolicina,
            this.Iznos});
            this.Ispis.Location = new System.Drawing.Point(472, 117);
            this.Ispis.MultiSelect = false;
            this.Ispis.Name = "Ispis";
            this.Ispis.ReadOnly = true;
            this.Ispis.RowHeadersVisible = false;
            this.Ispis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Ispis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ispis.Size = new System.Drawing.Size(224, 375);
            this.Ispis.TabIndex = 70;
            this.Ispis.TabStop = false;
            // 
            // Artikal
            // 
            this.Artikal.HeaderText = "Artikal";
            this.Artikal.Name = "Artikal";
            this.Artikal.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 50;
            // 
            // Iznos
            // 
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            this.Iznos.Width = 60;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(491, 536);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(205, 120);
            this.button17.TabIndex = 71;
            this.button17.TabStop = false;
            this.button17.Text = "Ukloni označeni artikal iz računa";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.UkloniArtikal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(725, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 29);
            this.textBox1.TabIndex = 74;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Artikli niski na stanju";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.logOutButton.Location = new System.Drawing.Point(725, 441);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(271, 89);
            this.logOutButton.TabIndex = 75;
            this.logOutButton.TabStop = false;
            this.logOutButton.Text = "ODJAVI SE";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // leftInStock
            // 
            this.leftInStock.AutoSize = true;
            this.leftInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.leftInStock.Location = new System.Drawing.Point(408, 85);
            this.leftInStock.Name = "leftInStock";
            this.leftInStock.Size = new System.Drawing.Size(0, 25);
            this.leftInStock.TabIndex = 76;
            this.leftInStock.Visible = false;
            // 
            // currerentStatus
            // 
            this.currerentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currerentStatus.Location = new System.Drawing.Point(249, 547);
            this.currerentStatus.Name = "currerentStatus";
            this.currerentStatus.Size = new System.Drawing.Size(210, 109);
            this.currerentStatus.TabIndex = 77;
            this.currerentStatus.Text = "Trenutno stanje šanka";
            this.currerentStatus.UseVisualStyleBackColor = true;
            this.currerentStatus.Click += new System.EventHandler(this.currerentStatus_Click);
            // 
            // Juice_Vodka
            // 
            this.Juice_Vodka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Juice_Vodka.Location = new System.Drawing.Point(347, 333);
            this.Juice_Vodka.Name = "Juice_Vodka";
            this.Juice_Vodka.Size = new System.Drawing.Size(104, 100);
            this.Juice_Vodka.TabIndex = 78;
            this.Juice_Vodka.TabStop = false;
            this.Juice_Vodka.Text = "Juice Vodka";
            this.Juice_Vodka.UseVisualStyleBackColor = true;
            this.Juice_Vodka.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label7.Location = new System.Drawing.Point(392, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "preostalo na stanju";
            // 
            // showPreview
            // 
            this.showPreview.AutoSize = true;
            this.showPreview.Location = new System.Drawing.Point(15, 662);
            this.showPreview.Name = "showPreview";
            this.showPreview.Size = new System.Drawing.Size(123, 17);
            this.showPreview.TabIndex = 83;
            this.showPreview.Text = "Pokazi prije printanja";
            this.showPreview.UseVisualStyleBackColor = true;
            // 
            // Kisela_voda
            // 
            this.Kisela_voda.BackgroundImage = global::Startni.Properties.Resources.kisela;
            this.Kisela_voda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Kisela_voda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kisela_voda.Location = new System.Drawing.Point(347, 440);
            this.Kisela_voda.Name = "Kisela_voda";
            this.Kisela_voda.Size = new System.Drawing.Size(104, 100);
            this.Kisela_voda.TabIndex = 81;
            this.Kisela_voda.TabStop = false;
            this.Kisela_voda.Text = "Kisela voda";
            this.Kisela_voda.UseVisualStyleBackColor = true;
            this.Kisela_voda.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Vodka
            // 
            this.Vodka.BackgroundImage = global::Startni.Properties.Resources.vodka;
            this.Vodka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Vodka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Vodka.Location = new System.Drawing.Point(237, 335);
            this.Vodka.Name = "Vodka";
            this.Vodka.Size = new System.Drawing.Size(104, 100);
            this.Vodka.TabIndex = 80;
            this.Vodka.TabStop = false;
            this.Vodka.UseVisualStyleBackColor = true;
            this.Vodka.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Jagoda
            // 
            this.Jagoda.BackgroundImage = global::Startni.Properties.Resources.NEKTAR_JAGODA_0_2L_500x500;
            this.Jagoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Jagoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jagoda.Location = new System.Drawing.Point(15, 441);
            this.Jagoda.Name = "Jagoda";
            this.Jagoda.Size = new System.Drawing.Size(108, 100);
            this.Jagoda.TabIndex = 79;
            this.Jagoda.TabStop = false;
            this.Jagoda.Text = "Jagoda";
            this.Jagoda.UseVisualStyleBackColor = true;
            this.Jagoda.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Juice
            // 
            this.Juice.BackgroundImage = global::Startni.Properties.Resources.juice;
            this.Juice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Juice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Juice.Location = new System.Drawing.Point(237, 441);
            this.Juice.Name = "Juice";
            this.Juice.Size = new System.Drawing.Size(104, 100);
            this.Juice.TabIndex = 66;
            this.Juice.TabStop = false;
            this.Juice.Text = "Juice";
            this.Juice.UseVisualStyleBackColor = true;
            this.Juice.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Guarana
            // 
            this.Guarana.BackgroundImage = global::Startni.Properties.Resources.guarana;
            this.Guarana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Guarana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Guarana.Location = new System.Drawing.Point(129, 333);
            this.Guarana.Name = "Guarana";
            this.Guarana.Size = new System.Drawing.Size(104, 100);
            this.Guarana.TabIndex = 65;
            this.Guarana.TabStop = false;
            this.Guarana.UseVisualStyleBackColor = true;
            this.Guarana.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Nektar
            // 
            this.Nektar.BackgroundImage = global::Startni.Properties.Resources.logo_nektar;
            this.Nektar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nektar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nektar.Location = new System.Drawing.Point(237, 123);
            this.Nektar.Name = "Nektar";
            this.Nektar.Size = new System.Drawing.Size(104, 100);
            this.Nektar.TabIndex = 63;
            this.Nektar.TabStop = false;
            this.Nektar.UseVisualStyleBackColor = true;
            this.Nektar.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Coca_cola
            // 
            this.Coca_cola.BackgroundImage = global::Startni.Properties.Resources.coca_cola;
            this.Coca_cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coca_cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Coca_cola.Location = new System.Drawing.Point(129, 440);
            this.Coca_cola.Name = "Coca_cola";
            this.Coca_cola.Size = new System.Drawing.Size(104, 100);
            this.Coca_cola.TabIndex = 61;
            this.Coca_cola.TabStop = false;
            this.Coca_cola.UseVisualStyleBackColor = true;
            this.Coca_cola.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Heineken
            // 
            this.Heineken.BackgroundImage = global::Startni.Properties.Resources.preview_Heineken29;
            this.Heineken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heineken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Heineken.Location = new System.Drawing.Point(127, 123);
            this.Heineken.Name = "Heineken";
            this.Heineken.Size = new System.Drawing.Size(104, 100);
            this.Heineken.TabIndex = 58;
            this.Heineken.TabStop = false;
            this.Heineken.UseVisualStyleBackColor = true;
            this.Heineken.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // red_bull
            // 
            this.red_bull.BackgroundImage = global::Startni.Properties.Resources.redBull;
            this.red_bull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.red_bull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.red_bull.Location = new System.Drawing.Point(17, 334);
            this.red_bull.Name = "red_bull";
            this.red_bull.Size = new System.Drawing.Size(106, 100);
            this.red_bull.TabIndex = 50;
            this.red_bull.TabStop = false;
            this.red_bull.UseVisualStyleBackColor = true;
            this.red_bull.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Jelen
            // 
            this.Jelen.BackgroundImage = global::Startni.Properties.Resources.jelen;
            this.Jelen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Jelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jelen.Location = new System.Drawing.Point(347, 122);
            this.Jelen.Name = "Jelen";
            this.Jelen.Size = new System.Drawing.Size(106, 100);
            this.Jelen.TabIndex = 44;
            this.Jelen.TabStop = false;
            this.Jelen.UseVisualStyleBackColor = true;
            this.Jelen.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // Tuborg
            // 
            this.Tuborg.BackgroundImage = global::Startni.Properties.Resources.Tuborg;
            this.Tuborg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tuborg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tuborg.Location = new System.Drawing.Point(15, 123);
            this.Tuborg.Name = "Tuborg";
            this.Tuborg.Size = new System.Drawing.Size(106, 100);
            this.Tuborg.TabIndex = 6;
            this.Tuborg.TabStop = false;
            this.Tuborg.UseVisualStyleBackColor = true;
            this.Tuborg.Click += new System.EventHandler(this.FormButtonClick);
            // 
            // printBillCheckBox
            // 
            this.printBillCheckBox.AutoSize = true;
            this.printBillCheckBox.Checked = true;
            this.printBillCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printBillCheckBox.Location = new System.Drawing.Point(249, 662);
            this.printBillCheckBox.Name = "printBillCheckBox";
            this.printBillCheckBox.Size = new System.Drawing.Size(120, 17);
            this.printBillCheckBox.TabIndex = 84;
            this.printBillCheckBox.Text = "Printaj fiskalni racun";
            this.printBillCheckBox.UseVisualStyleBackColor = true;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.printBillCheckBox);
            this.Controls.Add(this.showPreview);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Kisela_voda);
            this.Controls.Add(this.Vodka);
            this.Controls.Add(this.Jagoda);
            this.Controls.Add(this.Juice_Vodka);
            this.Controls.Add(this.currerentStatus);
            this.Controls.Add(this.leftInStock);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.Ispis);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Juice);
            this.Controls.Add(this.Guarana);
            this.Controls.Add(this.Crno_vino);
            this.Controls.Add(this.Nektar);
            this.Controls.Add(this.Coca_cola);
            this.Controls.Add(this.Bambus);
            this.Controls.Add(this.Bijelo_vino);
            this.Controls.Add(this.Heineken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.red_bull);
            this.Controls.Add(this.Gemišt);
            this.Controls.Add(this.Jelen);
            this.Controls.Add(this.dodatnoDugme);
            this.Controls.Add(this.upozorenja);
            this.Controls.Add(this.presjekTekst);
            this.Controls.Add(this.presjek);
            this.Controls.Add(this.stanjeSanka);
            this.Controls.Add(this.potvrdi_unos);
            this.Controls.Add(this.Tuborg);
            this.Controls.Add(this.nazivArtikla);
            this.Controls.Add(this.sifraArtikla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Glavni";
            this.Activated += new System.EventHandler(this.PocetnaForma_Activated);
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ispis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sifraArtikla;
        private System.Windows.Forms.ComboBox nazivArtikla;
        private System.Windows.Forms.Button Tuborg;
        private System.Windows.Forms.Button potvrdi_unos;
        private System.Windows.Forms.Button stanjeSanka;
        private System.Windows.Forms.TextBox presjekTekst;
        private System.Windows.Forms.Button presjek;
        private System.Windows.Forms.ListBox upozorenja;
        private System.Windows.Forms.Button dodatnoDugme;
        private System.Windows.Forms.Button Jelen;
        private System.Windows.Forms.Button Gemišt;
        private System.Windows.Forms.Button red_bull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Coca_cola;
        private System.Windows.Forms.Button Bambus;
        private System.Windows.Forms.Button Bijelo_vino;
        private System.Windows.Forms.Button Heineken;
        private System.Windows.Forms.Button Juice;
        private System.Windows.Forms.Button Guarana;
        private System.Windows.Forms.Button Crno_vino;
        private System.Windows.Forms.Button Nektar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.DataGridView Ispis;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.Label leftInStock;
        private System.Windows.Forms.Button currerentStatus;
        private System.Windows.Forms.Button Juice_Vodka;
        private System.Windows.Forms.Button Jagoda;
        private System.Windows.Forms.Button Vodka;
        private System.Windows.Forms.Button Kisela_voda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox showPreview;
        private System.Windows.Forms.CheckBox printBillCheckBox;
    }
}

