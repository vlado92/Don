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
using System.Security.Cryptography;

namespace Don
{
    public partial class PocetnaForma : Form
    {
        #region Print Variables
        public const int fontSize = 12;
        public static int billWidth = 570; //milimetri
        #endregion

        #region Variables
        private static string basePath = "D:\\Don\\DonBaza.sdf";
        public static string connString = @"Data Source=" + basePath;
        public static SqlCeConnection conn = new SqlCeConnection(connString);
        private SqlCeCommand command;
        private SqlCeDataReader reader;
        public static int role = 0;
        public static string userName = "Konobar";
        int glassesInBottle = 1;
        Boolean isReturningFromAnotherForm = false;
        public static int userCode = -1;
        string output = "";
        string centeredOutput = "";
        int numberOfRows = 0;
            

        public enum TipRadnika { Nepoznat = -1, Konobar = 0, Sef = 1, Admin = 2 }
        #endregion

        #region Form Functions
        public PocetnaForma()
        {
            InitializeComponent();
            CheckDatabase();
        }
        private void PocetnaForma_Activated(object sender, EventArgs e)
        {
            if (isReturningFromAnotherForm)
            {
                FillData(role);
                isReturningFromAnotherForm = false;
            }
        }
        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            //Prijava prijave = new Prijava();
            //DialogResult result = prijave.ShowDialog();
            //if (result == System.Windows.Forms.DialogResult.Cancel)
            //  Dispose();
            //else
            //{
            FillData(role);
            //}
        }

        private void CheckDatabase()
        {
            conn.ConnectionString = connString;
            SqlCeEngine en = new SqlCeEngine(connString);
            if (!System.IO.Directory.Exists(basePath.Substring(0, basePath.LastIndexOf("\\"))))
                System.IO.Directory.CreateDirectory(basePath.Substring(0, basePath.LastIndexOf("\\")));

            if (!System.IO.File.Exists(basePath))
            {
                en.CreateDatabase();
                try
                {
                    conn.Close();
                    conn.Open();
                    SqlCeCommand command = new SqlCeCommand();
                    command.Connection = conn;

                    command.CommandText = "CREATE TABLE Zaposleni("
                        + "ID INT NOT NULL PRIMARY KEY IDENTITY(0,1) ,"
                        + "korisnicko nvarchar(20) NOT NULL, "
                        + "sifra nvarchar(64 ), "
                        + "ime nvarchar(20) NOT NULL, "
                        + "prezime nvarchar(20) NOT NULL, "
                        + "tip INT NOT NULL);";
                    command.ExecuteNonQuery();
                    command.CommandText = "CREATE TABLE Artikal("
                        + "id INT NOT NULL PRIMARY KEY IDENTITY(0,1) , "
                        + "Naziv nvarchar(30) NOT NULL,"
                        + "Cijena nvarchar(30) NOT NULL, "
                        + "Stanje nvarchar(30), "
                        + "Jedinica nvarchar(30) NOT NULL,"
                        + "upozorenje nvarchar(30) NOT NULL,"
                        + "casaUFlasi INT, "
                        + "sifra nvarchar(30) NOT NULL,"
                        + "kombinacija bit);";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE kombinacija("
                        + "ID INT NOT NULL PRIMARY KEY IDENTITY(0,1) ,"
                        + "product1 INT NOT NULL, "
                        + "quantity1 nvarchar(20), "
                        + "product2 INT NOT NULL, "
                        + "quantity2 nvarchar(20));";
                    command.ExecuteNonQuery();
                    command.CommandText = "CREATE TABLE Racun("
                                            + "id INT NOT NULL PRIMARY KEY IDENTITY(0,1),"
                                            + "datum datetime NOT NULL,"
                                            + "Iznos nvarchar(30) NOT NULL,"
                                            + "konobarID INT);";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE racun_artikal("
                        + "id INT NOT NULL PRIMARY KEY IDENTITY(0,1),"
                        + "racun_id INT NOT NULL,"
                        + "artikal_id INT NOT NULL,"
                        + "kolicina_artikla nvarchar(30) NOT NULL, "
                        + "FOREIGN KEY (racun_id) REFERENCES racun(id),"
                        + "FOREIGN KEY (artikal_id) REFERENCES artikal(id));";
                    command.ExecuteNonQuery();

                    command.CommandText = "CREATE TABLE presjek_dana("
                        + "id INT NOT NULL PRIMARY KEY IDENTITY(0,1),"
                        + "vreme_presjeka datetime NOT NULL,"
                        + "kolicina nvarchar(30) NOT NULL);";
                    command.ExecuteNonQuery();

                    string sifra = HashNewPassword("230919922");

                    command.CommandText = "INSERT INTO Zaposleni(korisnicko, sifra, ime, prezime, tip) VALUES"
                        + "('admin', '" + sifra + "', 'Vladimir', 'Kunarac', 2);";
                    command.ExecuteNonQuery();

                }
                catch (SqlCeException)
                {
                    DialogResult button = MessageBox.Show(this, "Nije moguće uspostaviti konekciju sa bazom. Želite da nastavite?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (button == System.Windows.Forms.DialogResult.No)
                        this.Dispose();
                }
                conn.Close();
            }
        }
        private void FillData(int tip)
        {
            Ispis.AllowUserToAddRows = false;

            nazivArtikla.Items.Clear();
            sifraArtikla.Items.Clear();
            showPreview.Checked = false;
            printBillCheckBox.Checked = true;
            presjekTekst.Text =leftInStock.Text= "";
            
            leftInStock.Visible = false;

          //  imeKonobara.Text = ime + " " + prezime;
            if (tip == (int)TipRadnika.Admin || tip == (int)TipRadnika.Sef)
                dodatnoDugme.Visible = true;
            else
                dodatnoDugme.Visible = false;
            if (tip == (int)TipRadnika.Admin)
                showPreview.Visible = printBillCheckBox.Visible = true;
            else
                showPreview.Visible = printBillCheckBox.Visible = false;
            command = new SqlCeCommand("", conn);
            command.CommandText = "SELECT sifra, Naziv, casaUFlasi, kombinacija FROM Artikal ORDER BY sifra;";

            conn.Close();
            conn.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sifraArtikla.Items.Add(reader.GetInt32(0));
                if (reader.GetInt32(2) > 1)
                {
                    sifraArtikla.Items.Add(reader.GetInt32(0));
                    nazivArtikla.Items.Add(reader.GetString(1) + " čaša");
                    nazivArtikla.Items.Add(reader.GetString(1) + " flaša");
                }
                else if (reader.GetInt32(2) == 1)
                    nazivArtikla.Items.Add(reader.GetString(1));
                else
                    nazivArtikla.Items.Add(reader.GetString(1) + " kombinacija");
            }
            conn.Close();
            TestStock();

            Ispis.Rows.Clear();
            Ispis.Refresh();

            sifraArtikla.SelectedIndex = -1;
            sifraArtikla.Text = "";
            nazivArtikla.Text = "";
            nazivArtikla.SelectedIndex = -1;

        }
        #endregion

        #region Buttons
        private void potvrdi_unos_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

               DialogResult result = new EnterPass().ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                command.CommandText = "INSERT INTO Racun(datum, iznos, konobarID) VALUES ('" + convertDateTimeToDatabaseFormat(DateTime.Now) + "', '" + CalculateBill() + "'," + userCode +");";
                command.ExecuteNonQuery();

                command.CommandText = "SELECT MAX(id) FROM Racun;";
                reader = command.ExecuteReader();
                reader.Read();
                int    racID = reader.GetInt32(0);
                
                SqlCeDataReader articalReader;
                SqlCeCommand secondCommand = new SqlCeCommand("", conn);
                for (int i = 0; i < Ispis.Rows.Count; i++)
                {
                    command.CommandText = "SELECT id FROM Artikal WHERE naziv = '" + getOnlyNameOfItem(Ispis[0, i].Value.ToString()) + "';";
                    articalReader = command.ExecuteReader();
                    articalReader.Read();
                    secondCommand.CommandText = "INSERT INTO racun_artikal(racun_id, artikal_id, kolicina_artikla) VALUES"
                        + "(" + (racID) + ", " + articalReader.GetInt32(0) + ", " + Ispis[1, i].Value.ToString() + ");";
                    secondCommand.ExecuteNonQuery();
                }
                conn.Close();
            
                printBill(racID);
                nazivArtikla.Focus();
            }
        }
        private void BarInformation_Click(object sender, EventArgs e)
        {
            isReturningFromAnotherForm = true;
            new Stanje().Show();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            Prijava prijave = new Prijava();
            DialogResult result = prijave.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
                Dispose();
            else
            {
                FillData(role);
            }
        }
        private void BossButton_Click(object sender, EventArgs e)
        {
            isReturningFromAnotherForm = true;
            new DodatneOpcije().Show();
        }
        private void dodajArtikal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sifraArtikla.Text) || string.IsNullOrEmpty(nazivArtikla.Text))
            {
                MessageBox.Show("Nije unesen artikal");
                nazivArtikla.Focus();
            }
            else
            {
                conn.Close();
                conn.Open();
                bool exist = false;
                double stanje = 0;
                command.CommandText = "SELECT casaUFlasi, kombinacija, stanje FROM Artikal WHERE naziv = '" + getOnlyNameOfItem(nazivArtikla.Text) + "';";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (nazivArtikla.Text.EndsWith("čaša"))
                        glassesInBottle = reader.GetInt32(0);
                    else if (nazivArtikla.Text.EndsWith("flaša"))
                        glassesInBottle = 1;
                    else
                        glassesInBottle = 1;
                    stanje = double.Parse(reader.GetString(2));
                }
                for (int i = 0; i < Ispis.RowCount; i++)
                    if (nazivArtikla.Text.Equals(Ispis[0, i].Value.ToString()))
                    {
                        if (IsInStock(sifraArtikla.SelectedItem.ToString(), Double.Parse(Ispis[1, i].Value.ToString()) + 1, glassesInBottle))
                        {
                            if (UpdateStanje(nazivArtikla.Text, 0))
                            {
                                Ispis[1, i].Value = Int32.Parse(Ispis[1, i].Value.ToString()) + 1;
                                Ispis[2, i].Value = ConvertDoubleToPrintFormat("" + (double.Parse(Ispis[1, i].Value.ToString()) * getPrice(Ispis[0, i].Value.ToString())) / glassesInBottle);
                            }
                        }
                        else
                            MessageBox.Show("Nema vise na stanju");
                        exist = true;
                    }
                if (!exist)
                {
                    DataGridViewRow row;
                    Ispis.AllowUserToAddRows = true;
                    row = (DataGridViewRow)Ispis.Rows[0].Clone();
                    try
                    {
                        if (IsInStock(sifraArtikla.SelectedItem.ToString(), 1, glassesInBottle))
                        {
                            if (UpdateStanje(nazivArtikla.Text, 1))
                            {
                                command.CommandText = "SELECT cijena, stanje, casaUFlasi FROM Artikal "
                                    + "WHERE sifra = '" + sifraArtikla.SelectedItem.ToString() + "';";
                                reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    row = (DataGridViewRow)Ispis.Rows[0].Clone();
                                    row.Cells[0].Value = "" + nazivArtikla.Text.ToString();
                                    row.Cells[1].Value = 1;
                                    row.Cells[2].Value = "" + ConvertDoubleToPrintFormat("" + Double.Parse(reader.GetString(0)) / glassesInBottle);

                                    Ispis.Rows.Add(row);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nema na stanju");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ne postoji artikal! " + ex.ToString());
                    }
                    Ispis.ClearSelection();
                    Ispis.AllowUserToAddRows = false;
                }
                conn.Close();
            }
        }
        private void presjek_Click(object sender, EventArgs e)
        {
            double presjek = 0;
            string datum = "0000-00-00";
            command.CommandText = "SELECT COUNT(id) FROM Presjek_dana;";
            conn.Close();
            conn.Open();
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.GetInt32(0) > 0)
            {
                command.CommandText = "SELECT vreme_presjeka FROM Presjek_dana WHERE id = " + (reader.GetInt32(0) - 1) + ";";
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    datum = convertDateTimeToDatabaseFormat(reader.GetDateTime(0));
                }
            }
            command.CommandText = "SELECT iznos, datum FROM Racun "
                + " WHERE datum > '" + datum + "';";
            SqlCeDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Console.Out.WriteLine(read.GetDateTime(1));
                presjek += Double.Parse(read.GetString(0));
            }

            presjekTekst.Text = ConvertDoubleToPrintFormat(presjek.ToString()) + "KM";
            conn.Close();
        }
        private void UkloniArtikal_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = Ispis.SelectedRows;
            for (int i = 0; i < rows.Count; i++)
            {
                Ispis.Rows.RemoveAt(rows[i].Index);
            }
        }

        private void FormButtonClick(object sender, EventArgs e)
        {

            string temp = ((Button)sender).Name;
            string name = "";
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '_')
                    name += ' ';
                else
                    name += temp[i];
            if (sender.Equals(Jelen))
                sifraArtikla.SelectedIndex = nazivArtikla.SelectedIndex = 55;
            else
            {
                for (int counter = 0; counter < nazivArtikla.Items.Count; counter++)
                    if (nazivArtikla.Items[counter].ToString().Equals(name))
                    {
                        sifraArtikla.SelectedIndex = nazivArtikla.SelectedIndex = counter;
                        break;
                    }
                    else if (nazivArtikla.Items[counter].ToString().Contains(name))
                    {
                        Console.Out.WriteLine("Ovdje nije");
                        sifraArtikla.SelectedIndex = nazivArtikla.SelectedIndex = counter;
                        break;
                    }
            }
            dodajArtikal_Click(sender, e);
        }
        private void currerentStatus_Click(object sender, EventArgs e)
        {
            new currerentStatus().ShowDialog();
        }
        #endregion

        #region Functions
        private double getPrice(string nazivArtikla)
        {
            double broj = 0;
            command.CommandText = "SELECT cijena FROM Artikal WHERE Naziv = '" + getOnlyNameOfItem(nazivArtikla) + "';";

            reader = command.ExecuteReader();
            if (reader.Read())
                broj = Double.Parse(reader.GetString(0));
            return broj;
        }
        private string getOnlyNameOfItem(string fullName)
        {
            if (fullName.EndsWith("čaša"))
                return fullName.Substring(0, fullName.Length - 5);
            else if (fullName.EndsWith("flaša"))
                return fullName.Substring(0, fullName.Length - 6);
            else
                return fullName;

        }
        private void nazivArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            sifraArtikla.SelectedIndex = nazivArtikla.SelectedIndex;
            UpdateStanje(nazivArtikla.Text, -1);
        }
        private Boolean UpdateStanje(string articalName, int isAdded)
        {
            double stateInStock = 0;
            int glassesInBottle = 0;
            leftInStock.Visible = true;
            Boolean connClosed = (conn.State == ConnectionState.Closed) ? (true) : (false);
            if (connClosed)
                conn.Open();
            reader = new SqlCeCommand("SELECT Stanje, naziv, casaUFlasi, kombinacija FROM Artikal WHERE Naziv = '"
                + getOnlyNameOfItem(articalName) + "'", conn).ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetInt32(3) < 0)
                {
                    leftInStock.Visible = true;
                    stateInStock = double.Parse(reader.GetString(0));
                    glassesInBottle = reader.GetInt32(2);
                }
                else
                {
                    leftInStock.Visible = false;
                    return true;
                }
            }
            else
            {
                leftInStock.Visible = false;
                return false;
            }
            double toPrint = stateInStock;

            if (isAdded >= 0)
            {
                int artiState = (articalName.EndsWith("čaša")) ? (glassesInBottle) : (1);
                toPrint -= (isAdded == 1) ? (1 / artiState) : (0);
                for (int i = 0; i < Ispis.Rows.Count; i++)
                {
                    if (!Ispis.Rows[i].IsNewRow)
                        if (Ispis[0, i].Value.ToString().Contains(getOnlyNameOfItem(articalName)))
                        {
                            if (Ispis[0, i].Value.ToString().EndsWith("čaša"))
                            {
                                toPrint = toPrint - (double.Parse(Ispis[1, i].Value.ToString()) / glassesInBottle + (double)(1 / artiState));
                                Console.Out.WriteLine(toPrint);
                            }
                            else
                            {
                                toPrint -= (1 / artiState + double.Parse(Ispis[1, i].Value.ToString()));
                                Console.Out.WriteLine(toPrint);
                            }


                        }
                }
                leftInStock.Text = ConvertDoubleToPrintFormat("" + toPrint);
                if (connClosed)
                    conn.Close();
                if (toPrint >= 0)
                    return true;
                else
                {
                    MessageBox.Show("Nema vise na stanju");
                    return false;
                }
            }
            else
            {
                leftInStock.Visible = false;
                return false;
            }
        }
        private void sifraArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            nazivArtikla.SelectedIndex = sifraArtikla.SelectedIndex;
            UpdateStanje(nazivArtikla.Text, -1);
        }
        private string CalculateBill()
        {
            double bill = 0;
            for (int i = 0; i < Ispis.Rows.Count; i++)
                bill += double.Parse(Ispis[2, i].Value.ToString());
            return "" + bill;
        }
        private void printBill(int racID = 1)
        {
            output = centeredOutput = "";
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            
            PrintDocument print = new PrintDocument();
            Graphics g = print.PrinterSettings.CreateMeasurementGraphics();
            Font myFont = new Font("Times New Roman", fontSize, FontStyle.Regular, GraphicsUnit.Millimeter);

            string lines = "";
            string doubleLines = "";
            bool centerLines = false;
            for (int i = 0; i < (int)(billWidth / g.MeasureString("-", myFont).Width); i++)
            {
                lines += "--";
            }
            for (int i = 0; i < 20; i++)
                doubleLines += "=";
            output += "\n";
            output += "\n";
            numberOfRows = 3;
            addText("Club Don PALE", true);
            addText("Ulica Broj: Ive Andrica br. 5", true);
            addText("VL: Radovic Vladimir", true);
            addText(lines, centerLines);
            addText("JIB: 4501709930005", false);
            addText("IPO: 000000000000", false);
            addText("IBFM: EA103780", false);
            addText(lines, centerLines);
          //  if(printajFiskalni.Checked)
                addText("N A R U Dž B A", true);
            addText(lines, centerLines);

            if (Ispis.RowCount > 0)
            {
                for (int i = 0; i < Ispis.RowCount; i++)
                    if (Ispis.Rows[i].Visible)
                    {
                        UpdateStock(Ispis[0, i].Value.ToString(), Double.Parse(Ispis[1, i].Value.ToString()));
                        addText(Ispis[0, i].Value.ToString(), false, false);
                        addText("      " + ConvertDoubleToPrintFormat(Ispis[1, i].Value.ToString()) + "x"
                                   + "      " + ConvertDoubleToPrintFormat("" + (double.Parse((Ispis[2, i].Value.ToString()))
                                            / int.Parse(Ispis[1, i].Value.ToString())))
                        + "          " + ConvertDoubleToPrintFormat(Ispis[2, i].Value.ToString()), false, false);
                    }
            
                addText(lines, centerLines);
                addText("СЕ: 17%", false);
                double bill = double.Parse(CalculateBill());
                double billPDV = bill / 100 * (14.529914529914529914529914529915);
                addText("ПE:\t\t" + ConvertDoubleToPrintFormat("" + billPDV), false);
                addText("ПУ:\t\t" + ConvertDoubleToPrintFormat("" + billPDV), false);
                addText("ЕЕ:\t\t" + ConvertDoubleToPrintFormat("" + bill), false);
                addText("EУ:\t\t" + ConvertDoubleToPrintFormat("" + bill), false);
                addText("ЕБ:\t\t" + ConvertDoubleToPrintFormat("" + (bill - billPDV)), false);
                addText(lines, centerLines);
                addText("ZA UPLATU:\t" + ConvertDoubleToPrintFormat(bill), false);
                addText("GOTOVINA:\t" + ConvertDoubleToPrintFormat(bill), false);
                addText("UPLAĆENO:\t" + ConvertDoubleToPrintFormat(bill), false);
                addText("POVRAT:\t0,00", false);
                addText(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), false);
                addText("RBR: " + racID, false);
                addText(doubleLines, centerLines);
                addText("*HVALA NA POVJERENjU*", true);
           
                print.DefaultPageSettings.PaperSize = new PaperSize("moja", billWidth, (int)((numberOfRows + Ispis.Rows.Count * 2) * g.MeasureString("1", myFont).Height));
           
                print.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(output, myFont, new SolidBrush(Color.Black),
                        new RectangleF(0, 0, print.DefaultPageSettings.PrintableArea.Width,
                        print.DefaultPageSettings.PrintableArea.Height));

                    e1.Graphics.DrawString(centeredOutput, myFont, new SolidBrush(Color.Black),
                        new RectangleF(0, 0, print.DefaultPageSettings.PrintableArea.Width,
                        print.DefaultPageSettings.PrintableArea.Height), format);

                    float y = g.MeasureString("a", myFont).Height * (numberOfRows - 5 + Ispis.Rows.Count * 2) - (numberOfRows - 5 + Ispis.Rows.Count * 2);
                    e1.Graphics.DrawImage(Image.FromFile("D:\\Don\\slike\\logo.png"), billWidth*2/3, y, 50, 50);
                };
                PrintPreviewDialog pdi = new PrintPreviewDialog();
                pdi.Document = print;
                if(showPreview.Checked)
                  pdi.ShowDialog();
            
                try
                {
                    if (printBillCheckBox.Checked)
                        print.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }

            FillData(role);
        }

        private void addText(string text, Boolean centered, Boolean move = true)
        {
            if (centered)
            {
                output += "\n";
                centeredOutput += text + "\n";
            }
            else
            {
                output += text + "\n";
                centeredOutput += "\n";
            }
            if(move)
                numberOfRows++;
        }

        public static string ConvertDoubleToPrintFormat(double input)
        {
            return ConvertDoubleToPrintFormat(input.ToString());
        }
        public static string ConvertDoubleToPrintFormat(string input)
        {
            int positionOfComma = input.IndexOf(',');
            if (positionOfComma < 0)
                return input + ",00";
            else if (input.Substring(positionOfComma + 1).Length < 2)
                return input + "0";
            else if (input.Substring(positionOfComma + 1).Length == 2)
                return input.Substring(0, positionOfComma + 3);
            else
            {
                int number = int.Parse(input.Substring(positionOfComma + 1, 3));
                if (number % 10 > 5)
                    number += 10;
                number /= 10;
                double temp = double.Parse(input.Substring(0, positionOfComma));
                temp += (double)number / 100;
                return "" + temp;
            }
        }
        public static string convertDateTimeToDatabaseFormat(DateTime time)
        {
            return time.Year + "-"
            + ((time.Month < 10) ? ("0" + time.Month) : ("" + time.Month)) + "-"
            + ((time.Day < 10) ? ("0" + time.Day) : ("" + time.Day)) + " "
            + ((time.Hour < 10) ? ("0" + time.Hour) : ("" + time.Hour)) + ":"
            + ((time.Minute < 10) ? ("0" + time.Minute) : ("" + time.Minute)) + ":"
            + ((time.Second < 10) ? ("0" + time.Second) : ("" + time.Second));
        }

        private static string hashPassword(string password)
        {
            SHA256Managed sha256 = new SHA256Managed();

            byte[] passwordInBytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(passwordInBytes);

            return Convert.ToBase64String(hash);
        }
        public static string HashNewPassword(string password)
        {
            return hashPassword(password);
        }
        #endregion

        #region Stock Functions
        private Boolean IsInStock(string sifra, double kolicina, int glasses)
        {
            command.CommandText = "SELECT Stanje, casaUFlasi, kombinacija FROM Artikal WHERE sifra = '" + sifra + "';";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt32(2) < 0)
                {
                    if (Double.Parse(reader.GetString(0)) - kolicina / glasses >= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //imam iz artikla sifru artikla koji je kombinacija IE 33
                    SqlCeCommand reserveCommand = new SqlCeCommand("SELECT product1, quantity1, product2, quantity2 FROM kombinacija WHERE id = " + reader.GetInt32(2) + ";", conn);

                    SqlCeDataReader kombinacijaReader = reserveCommand.ExecuteReader();
                    SqlCeDataReader art2Reader, art1Reader;
                    if (kombinacijaReader.Read())
                    {
                        art1Reader = new SqlCeCommand("SELECT Stanje FROM Artikal WHERE sifra = '" + kombinacijaReader.GetString(0) + "';"
                             , conn).ExecuteReader();
                        art2Reader = new SqlCeCommand("SELECT Stanje FROM Artikal WHERE sifra = '" + kombinacijaReader.GetString(2) + "';"
                                                    , conn).ExecuteReader();
                        if (art2Reader.Read() && art1Reader.Read())
                        {
                            if (Double.Parse(art1Reader.GetString(0)) - Double.Parse(kombinacijaReader.GetString(1)) >= 0)
                                if (Double.Parse(art2Reader.GetString(0)) - Double.Parse(kombinacijaReader.GetString(3)) >= 0)
                                    return true;
                        }
                    }
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void UpdateStock(string naziv, double kolicina)
        {
            int type = 1;
            conn.Close();
            conn.Open();
            command.CommandText = "SELECT Stanje, casaUFlasi, kombinacija FROM ARTIKAL WHERE naziv = '" + getOnlyNameOfItem(naziv) + "';";
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (naziv.EndsWith("čaša"))
                    type = reader.GetInt32(1);
                else if (naziv.EndsWith("flaša"))
                    type = 1;
                if (reader.GetInt32(2) < 0)
                {
                    double stanje = Double.Parse(reader.GetString(0)) - kolicina / type;
                    command.CommandText = "UPDATE Artikal SET stanje = '" + stanje.ToString()
                        + "' WHERE naziv = '" + getOnlyNameOfItem(naziv) + "';";
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlCeDataReader secondReader = new SqlCeCommand("SELECT product1, product2, quantity1, quantity2 FROM kombinacija WHERE id = " + reader.GetInt32(2) + ";", conn).ExecuteReader();
                    if (secondReader.Read())
                    {
                        SqlCeDataReader tempReader = new SqlCeCommand("SELECT stanje, id FROM Artikal WHERE id = " + secondReader.GetInt32(0) + ";", conn).ExecuteReader();
                        tempReader.Read();
                        double stanje = double.Parse(tempReader.GetString(0)) - double.Parse(secondReader.GetString(2));
                        command.CommandText = "UPDATE Artikal SET stanje = '" + stanje.ToString()
                        + "' WHERE id = " + tempReader.GetInt32(1) + ";";
                        command.ExecuteNonQuery();
                        tempReader.Close();
                        tempReader = new SqlCeCommand("SELECT stanje, id FROM Artikal WHERE id = " + secondReader.GetInt32(2) + ";", conn).ExecuteReader();
                        tempReader.Read();
                        stanje = double.Parse(tempReader.GetString(0)) - double.Parse(secondReader.GetString(3));
                        command.CommandText = "UPDATE Artikal SET stanje = '" + stanje.ToString()
                        + "' WHERE id = " + tempReader.GetInt32(1) + ";";
                        command.ExecuteNonQuery();
                        tempReader.Close();
                    }
                }
            }
            else
                MessageBox.Show("Nema podataka");
            conn.Close();
            TestStock();
        }
        private void TestStock()
        {
            upozorenja.Items.Clear();
            conn.Close();
            conn.Open();
            command.CommandText = "SELECT Upozorenje, stanje,  naziv, kombinacija FROM Artikal;";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((Double.Parse(reader.GetString(0)) > Double.Parse(reader.GetString(1))) && reader.GetInt32(3) < 0)
                {
                    upozorenja.Items.Add(reader.GetString(2));
                }
            }
            conn.Close();
        }
        #endregion

    }
}