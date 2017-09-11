namespace Don
{
    partial class Stanje
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
            this.endOfDayList = new System.Windows.Forms.ListBox();
            this.button22 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button19 = new System.Windows.Forms.Button();
            this.artikalCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.naStanju = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dodajArtikle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printCheckBox = new System.Windows.Forms.CheckBox();
            this.showPreview = new System.Windows.Forms.CheckBox();
            this.warningBound = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endOfDayList
            // 
            this.endOfDayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endOfDayList.FormattingEnabled = true;
            this.endOfDayList.ItemHeight = 17;
            this.endOfDayList.Items.AddRange(new object[] {
            "Dana -- -- -- izdatno je:",
            "Piva: 200 (400KM)",
            "Vino: 150 (450KM)",
            "Konačno: 350 KM"});
            this.endOfDayList.Location = new System.Drawing.Point(281, 95);
            this.endOfDayList.Name = "endOfDayList";
            this.endOfDayList.Size = new System.Drawing.Size(249, 174);
            this.endOfDayList.TabIndex = 40;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.Location = new System.Drawing.Point(439, 10);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(91, 79);
            this.button22.TabIndex = 38;
            this.button22.Text = "Kraj dana";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.FinishDayButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, -23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(35, -26);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 33;
            this.button19.Text = "Ulaz robe";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // artikalCombo
            // 
            this.artikalCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.artikalCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.artikalCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artikalCombo.FormattingEnabled = true;
            this.artikalCombo.Location = new System.Drawing.Point(126, 12);
            this.artikalCombo.Name = "artikalCombo";
            this.artikalCombo.Size = new System.Drawing.Size(134, 26);
            this.artikalCombo.TabIndex = 41;
            this.artikalCombo.SelectedIndexChanged += new System.EventHandler(this.artikalCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Artikal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Artikla na stanju";
            // 
            // naStanju
            // 
            this.naStanju.Enabled = false;
            this.naStanju.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naStanju.Location = new System.Drawing.Point(140, 65);
            this.naStanju.Name = "naStanju";
            this.naStanju.Size = new System.Drawing.Size(120, 24);
            this.naStanju.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Dodaj artikala na stanje";
            // 
            // dodajArtikle
            // 
            this.dodajArtikle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajArtikle.Location = new System.Drawing.Point(176, 105);
            this.dodajArtikle.Name = "dodajArtikle";
            this.dodajArtikle.Size = new System.Drawing.Size(84, 24);
            this.dodajArtikle.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(16, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 112);
            this.button1.TabIndex = 47;
            this.button1.Text = "potvrdi unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateStockButton_Click);
            // 
            // printCheckBox
            // 
            this.printCheckBox.AutoSize = true;
            this.printCheckBox.Checked = true;
            this.printCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printCheckBox.Location = new System.Drawing.Point(301, 39);
            this.printCheckBox.Name = "printCheckBox";
            this.printCheckBox.Size = new System.Drawing.Size(132, 22);
            this.printCheckBox.TabIndex = 48;
            this.printCheckBox.Text = "Printaj kraj dana";
            this.printCheckBox.UseVisualStyleBackColor = true;
            // 
            // showPreview
            // 
            this.showPreview.AutoSize = true;
            this.showPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showPreview.Location = new System.Drawing.Point(281, 280);
            this.showPreview.Name = "showPreview";
            this.showPreview.Size = new System.Drawing.Size(103, 22);
            this.showPreview.TabIndex = 49;
            this.showPreview.Text = "Pokazi uvid";
            this.showPreview.UseVisualStyleBackColor = true;
            // 
            // warningBound
            // 
            this.warningBound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warningBound.Location = new System.Drawing.Point(191, 278);
            this.warningBound.Name = "warningBound";
            this.warningBound.Size = new System.Drawing.Size(69, 24);
            this.warningBound.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Izmjeni granicu upozorenja";
            // 
            // Stanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 283);
            this.Controls.Add(this.warningBound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPreview);
            this.Controls.Add(this.printCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodajArtikle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.naStanju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artikalCombo);
            this.Controls.Add(this.endOfDayList);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stanje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stanje";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StanjeSanka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox endOfDayList;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.ComboBox artikalCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naStanju;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dodajArtikle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox printCheckBox;
        private System.Windows.Forms.CheckBox showPreview;
        private System.Windows.Forms.TextBox warningBound;
        private System.Windows.Forms.Label label4;
    }
}