namespace Receptka
{
    partial class main_form
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
            System.Windows.Forms.Label pESELLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label imięLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.u_anuluj = new System.Windows.Forms.Button();
            this.u_dodjaknow = new System.Windows.Forms.Button();
            this.u_zapisz = new System.Windows.Forms.Button();
            this.u_aktualizuj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.u_kch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.u_adres = new System.Windows.Forms.TextBox();
            this.u_nazwisko = new System.Windows.Forms.TextBox();
            this.u_imie = new System.Windows.Forms.TextBox();
            this.rcp_menu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_wyjscie = new System.Windows.Forms.ToolStripMenuItem();
            this.receptaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_drukuj = new System.Windows.Forms.ToolStripMenuItem();
            this.m_podglad = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacjentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pierwszy = new System.Windows.Forms.ToolStripMenuItem();
            this.m_poprzedni = new System.Windows.Forms.ToolStripMenuItem();
            this.m_nastepny = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ostatni = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.m_dodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.m_edycja = new System.Windows.Forms.ToolStripMenuItem();
            this.m_aktualizuj = new System.Windows.Forms.ToolStripMenuItem();
            this.m_dodjaknow = new System.Windows.Forms.ToolStripMenuItem();
            this.m_usun = new System.Windows.Forms.ToolStripMenuItem();
            this.m_szukaj = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_pomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_informacje = new System.Windows.Forms.ToolStripMenuItem();
            this.t_www = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.t_drukuj = new System.Windows.Forms.ToolStripButton();
            this.t_podglad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.t_pierwszy = new System.Windows.Forms.ToolStripButton();
            this.t_poprzedni = new System.Windows.Forms.ToolStripButton();
            this.t_nastepny = new System.Windows.Forms.ToolStripButton();
            this.t_ostatni = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.t_dodaj = new System.Windows.Forms.ToolStripButton();
            this.t_edycja = new System.Windows.Forms.ToolStripDropDownButton();
            this.t_aktualizuj = new System.Windows.Forms.ToolStripMenuItem();
            this.t_dodjaknow = new System.Windows.Forms.ToolStripMenuItem();
            this.t_usun = new System.Windows.Forms.ToolStripButton();
            this.t_szukaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_pomoc = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.sqliteSelectCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteInsertCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteUpdateCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqliteDeleteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqLiteDataAdapter1 = new System.Data.SQLite.SQLiteDataAdapter();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.peselWarning = new System.Windows.Forms.ToolTip(this.components);
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.buttonfind = new System.Windows.Forms.Button();
            this.u_pesel = new Receptka.NumericTextBox();
            pESELLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            imięLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rcp_menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pESELLabel
            // 
            pESELLabel.AutoSize = true;
            pESELLabel.Location = new System.Drawing.Point(16, 187);
            pESELLabel.Name = "pESELLabel";
            pESELLabel.Size = new System.Drawing.Size(44, 13);
            pESELLabel.TabIndex = 11;
            pESELLabel.Text = "PESEL:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(16, 132);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 10;
            adresLabel.Text = "Adres:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(16, 78);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            nazwiskoLabel.TabIndex = 9;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imięLabel
            // 
            imięLabel.AutoSize = true;
            imięLabel.Location = new System.Drawing.Point(16, 32);
            imięLabel.Name = "imięLabel";
            imięLabel.Size = new System.Drawing.Size(29, 13);
            imięLabel.TabIndex = 8;
            imięLabel.Text = "Imię:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.u_anuluj);
            this.groupBox3.Controls.Add(this.u_dodjaknow);
            this.groupBox3.Controls.Add(this.u_zapisz);
            this.groupBox3.Controls.Add(this.u_aktualizuj);
            this.groupBox3.Location = new System.Drawing.Point(31, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 109);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operacje";
            // 
            // u_anuluj
            // 
            this.u_anuluj.Enabled = false;
            this.u_anuluj.Location = new System.Drawing.Point(391, 68);
            this.u_anuluj.Name = "u_anuluj";
            this.u_anuluj.Size = new System.Drawing.Size(90, 23);
            this.u_anuluj.TabIndex = 0;
            this.u_anuluj.Text = "Anuluj";
            this.tooltip.SetToolTip(this.u_anuluj, "Przycisk anulujący dodawanie nowego\r\npacjenta i wyświetlający ostatniego\r\ndodaneg" +
                    "o\r\nPrzycisk jest widoczny tylko podczas\r\ndodawania pacjenta do bazy danych");
            this.u_anuluj.UseVisualStyleBackColor = true;
            this.u_anuluj.Click += new System.EventHandler(this.anuluj);
            // 
            // u_dodjaknow
            // 
            this.u_dodjaknow.Location = new System.Drawing.Point(380, 29);
            this.u_dodjaknow.Name = "u_dodjaknow";
            this.u_dodjaknow.Size = new System.Drawing.Size(111, 23);
            this.u_dodjaknow.TabIndex = 0;
            this.u_dodjaknow.Text = "Dodaj jako nowego";
            this.tooltip.SetToolTip(this.u_dodjaknow, "Przycisk wpisujący wyżej podane dane\r\ndo bazy danych.");
            this.u_dodjaknow.UseVisualStyleBackColor = true;
            this.u_dodjaknow.Click += new System.EventHandler(this.addasnew);
            // 
            // u_zapisz
            // 
            this.u_zapisz.Enabled = false;
            this.u_zapisz.Location = new System.Drawing.Point(129, 68);
            this.u_zapisz.Name = "u_zapisz";
            this.u_zapisz.Size = new System.Drawing.Size(92, 23);
            this.u_zapisz.TabIndex = 0;
            this.u_zapisz.Text = "Zapisz";
            this.tooltip.SetToolTip(this.u_zapisz, "Przycisk wpisujący wyżej podane dane\r\ndo bazy danych.\r\n\r\nJest widoczny tylko przy" +
                    " dodawaniu\r\nnowego pacjenta.");
            this.u_zapisz.UseVisualStyleBackColor = true;
            this.u_zapisz.Click += new System.EventHandler(this.zapisz);
            // 
            // u_aktualizuj
            // 
            this.u_aktualizuj.Location = new System.Drawing.Point(129, 29);
            this.u_aktualizuj.Name = "u_aktualizuj";
            this.u_aktualizuj.Size = new System.Drawing.Size(92, 23);
            this.u_aktualizuj.TabIndex = 0;
            this.u_aktualizuj.Text = "Aktualizuj";
            this.tooltip.SetToolTip(this.u_aktualizuj, "Przycisk zmieniający dane aktualnie wyświetlanego\r\npacjenta na te wpisane w polac" +
                    "h powyżej");
            this.u_aktualizuj.UseVisualStyleBackColor = true;
            this.u_aktualizuj.Click += new System.EventHandler(this.aktualizuj);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonfind);
            this.groupBox2.Controls.Add(this.FindTextBox);
            this.groupBox2.Controls.Add(this.u_kch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(364, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 244);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatkowe";
            // 
            // u_kch
            // 
            this.u_kch.FormattingEnabled = true;
            this.u_kch.Location = new System.Drawing.Point(152, 29);
            this.u_kch.Name = "u_kch";
            this.u_kch.Size = new System.Drawing.Size(47, 21);
            this.u_kch.TabIndex = 7;
            this.tooltip.SetToolTip(this.u_kch, "To pole zawiera wartości od 01 do 16\r\nOznaczają one województwa Polski,\r\nsą ich n" +
                    "umerem");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kasa chorych";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(pESELLabel);
            this.groupBox1.Controls.Add(this.u_pesel);
            this.groupBox1.Controls.Add(adresLabel);
            this.groupBox1.Controls.Add(this.u_adres);
            this.groupBox1.Controls.Add(nazwiskoLabel);
            this.groupBox1.Controls.Add(this.u_nazwisko);
            this.groupBox1.Controls.Add(imięLabel);
            this.groupBox1.Controls.Add(this.u_imie);
            this.groupBox1.Location = new System.Drawing.Point(31, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 245);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe";
            // 
            // u_adres
            // 
            this.u_adres.Location = new System.Drawing.Point(114, 129);
            this.u_adres.Name = "u_adres";
            this.u_adres.Size = new System.Drawing.Size(129, 20);
            this.u_adres.TabIndex = 11;
            this.tooltip.SetToolTip(this.u_adres, "Adres pacjenta drukowany na recepcie\r\n\r\nTo pole automatycznie zmieni pierwszą\r\nli" +
                    "terę na wielką po ukończeniu edycji\r\ni usunięciu z niego kursora");
            this.u_adres.Leave += new System.EventHandler(this.adres_Leave);
            // 
            // u_nazwisko
            // 
            this.u_nazwisko.Location = new System.Drawing.Point(114, 75);
            this.u_nazwisko.Name = "u_nazwisko";
            this.u_nazwisko.Size = new System.Drawing.Size(129, 20);
            this.u_nazwisko.TabIndex = 10;
            this.tooltip.SetToolTip(this.u_nazwisko, "Nazwisko pacjenta drukowane na recepcie\r\n\r\nTo pole automatycznie zmieni pierwszą\r" +
                    "\nliterę na wielką po ukończeniu edycji\r\ni usunięciu z niego kursora");
            this.u_nazwisko.Leave += new System.EventHandler(this.nazwisko_Leave);
            // 
            // u_imie
            // 
            this.u_imie.Location = new System.Drawing.Point(114, 29);
            this.u_imie.Name = "u_imie";
            this.u_imie.Size = new System.Drawing.Size(129, 20);
            this.u_imie.TabIndex = 9;
            this.tooltip.SetToolTip(this.u_imie, "Imię pacjenta drukowane na recepcie\r\n\r\nTo pole automatycznie zmieni pierwszą\r\nlit" +
                    "erę na wielką po ukończeniu edycji\r\ni usunięciu z niego kursora");
            this.u_imie.Leave += new System.EventHandler(this.imie_Leave);
            // 
            // rcp_menu
            // 
            this.rcp_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.receptaToolStripMenuItem,
            this.pacjentToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.rcp_menu.Location = new System.Drawing.Point(3, 0);
            this.rcp_menu.Name = "rcp_menu";
            this.rcp_menu.Size = new System.Drawing.Size(668, 24);
            this.rcp_menu.TabIndex = 9;
            this.rcp_menu.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_wyjscie});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "&Program";
            // 
            // m_wyjscie
            // 
            this.m_wyjscie.Name = "m_wyjscie";
            this.m_wyjscie.Size = new System.Drawing.Size(114, 22);
            this.m_wyjscie.Text = "&Wyjście";
            this.m_wyjscie.Click += new System.EventHandler(this.wyjscie_Click);
            // 
            // receptaToolStripMenuItem
            // 
            this.receptaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_drukuj,
            this.m_podglad,
            this.formatToolStripMenuItem});
            this.receptaToolStripMenuItem.Name = "receptaToolStripMenuItem";
            this.receptaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.receptaToolStripMenuItem.Text = "&Recepta";
            // 
            // m_drukuj
            // 
            this.m_drukuj.Image = ((System.Drawing.Image)(resources.GetObject("m_drukuj.Image")));
            this.m_drukuj.Name = "m_drukuj";
            this.m_drukuj.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.m_drukuj.Size = new System.Drawing.Size(150, 22);
            this.m_drukuj.Text = "&Drukuj";
            this.m_drukuj.Click += new System.EventHandler(this.drukuj_Click);
            // 
            // m_podglad
            // 
            this.m_podglad.Image = ((System.Drawing.Image)(resources.GetObject("m_podglad.Image")));
            this.m_podglad.Name = "m_podglad";
            this.m_podglad.Size = new System.Drawing.Size(150, 22);
            this.m_podglad.Text = "Podglad";
            this.m_podglad.Click += new System.EventHandler(this.podglad_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.formatToolStripMenuItem.Text = "&Format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.format_Click);
            // 
            // pacjentToolStripMenuItem
            // 
            this.pacjentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_pierwszy,
            this.m_poprzedni,
            this.m_nastepny,
            this.m_ostatni,
            this.toolStripSeparator3,
            this.m_dodaj,
            this.m_edycja,
            this.m_usun,
            this.m_szukaj});
            this.pacjentToolStripMenuItem.Name = "pacjentToolStripMenuItem";
            this.pacjentToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pacjentToolStripMenuItem.Text = "&Pacjent";
            // 
            // m_pierwszy
            // 
            this.m_pierwszy.Image = ((System.Drawing.Image)(resources.GetObject("m_pierwszy.Image")));
            this.m_pierwszy.Name = "m_pierwszy";
            this.m_pierwszy.Size = new System.Drawing.Size(152, 22);
            this.m_pierwszy.Text = "Pierwszy";
            this.m_pierwszy.Click += new System.EventHandler(this.first);
            // 
            // m_poprzedni
            // 
            this.m_poprzedni.Image = ((System.Drawing.Image)(resources.GetObject("m_poprzedni.Image")));
            this.m_poprzedni.Name = "m_poprzedni";
            this.m_poprzedni.Size = new System.Drawing.Size(152, 22);
            this.m_poprzedni.Text = "Poprzedni";
            this.m_poprzedni.Click += new System.EventHandler(this.prev);
            // 
            // m_nastepny
            // 
            this.m_nastepny.Image = ((System.Drawing.Image)(resources.GetObject("m_nastepny.Image")));
            this.m_nastepny.Name = "m_nastepny";
            this.m_nastepny.Size = new System.Drawing.Size(152, 22);
            this.m_nastepny.Text = "Następny";
            this.m_nastepny.Click += new System.EventHandler(this.next);
            // 
            // m_ostatni
            // 
            this.m_ostatni.Image = ((System.Drawing.Image)(resources.GetObject("m_ostatni.Image")));
            this.m_ostatni.Name = "m_ostatni";
            this.m_ostatni.Size = new System.Drawing.Size(152, 22);
            this.m_ostatni.Text = "Ostatni";
            this.m_ostatni.Click += new System.EventHandler(this.last);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // m_dodaj
            // 
            this.m_dodaj.Image = ((System.Drawing.Image)(resources.GetObject("m_dodaj.Image")));
            this.m_dodaj.Name = "m_dodaj";
            this.m_dodaj.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.m_dodaj.Size = new System.Drawing.Size(152, 22);
            this.m_dodaj.Text = "Dodaj";
            this.m_dodaj.Click += new System.EventHandler(this.nowy);
            // 
            // m_edycja
            // 
            this.m_edycja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_aktualizuj,
            this.m_dodjaknow});
            this.m_edycja.Image = ((System.Drawing.Image)(resources.GetObject("m_edycja.Image")));
            this.m_edycja.Name = "m_edycja";
            this.m_edycja.Size = new System.Drawing.Size(152, 22);
            this.m_edycja.Text = "Edytuj";
            // 
            // m_aktualizuj
            // 
            this.m_aktualizuj.Name = "m_aktualizuj";
            this.m_aktualizuj.Size = new System.Drawing.Size(176, 22);
            this.m_aktualizuj.Text = "Aktualizuj";
            this.m_aktualizuj.Click += new System.EventHandler(this.aktualizuj);
            // 
            // m_dodjaknow
            // 
            this.m_dodjaknow.Name = "m_dodjaknow";
            this.m_dodjaknow.Size = new System.Drawing.Size(176, 22);
            this.m_dodjaknow.Text = "Dodaj jako nowego";
            this.m_dodjaknow.Click += new System.EventHandler(this.addasnew);
            // 
            // m_usun
            // 
            this.m_usun.Image = ((System.Drawing.Image)(resources.GetObject("m_usun.Image")));
            this.m_usun.Name = "m_usun";
            this.m_usun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.m_usun.Size = new System.Drawing.Size(152, 22);
            this.m_usun.Text = "Usuń";
            this.m_usun.Click += new System.EventHandler(this.usun);
            // 
            // m_szukaj
            // 
            this.m_szukaj.Image = ((System.Drawing.Image)(resources.GetObject("m_szukaj.Image")));
            this.m_szukaj.Name = "m_szukaj";
            this.m_szukaj.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.m_szukaj.Size = new System.Drawing.Size(152, 22);
            this.m_szukaj.Text = "Szukaj";
            this.m_szukaj.Click += new System.EventHandler(this.searchclick);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_pomoc,
            this.m_informacje,
            this.t_www});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // m_pomoc
            // 
            this.m_pomoc.Image = ((System.Drawing.Image)(resources.GetObject("m_pomoc.Image")));
            this.m_pomoc.Name = "m_pomoc";
            this.m_pomoc.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.m_pomoc.Size = new System.Drawing.Size(138, 22);
            this.m_pomoc.Text = "Pomoc";
            this.m_pomoc.Click += new System.EventHandler(this.pomoc);
            // 
            // m_informacje
            // 
            this.m_informacje.Image = global::Receptka.Properties.Resources.information;
            this.m_informacje.Name = "m_informacje";
            this.m_informacje.Size = new System.Drawing.Size(138, 22);
            this.m_informacje.Text = "Informacje";
            this.m_informacje.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // t_www
            // 
            this.t_www.Image = global::Receptka.Properties.Resources.icon_world;
            this.t_www.Name = "t_www";
            this.t_www.Size = new System.Drawing.Size(138, 22);
            this.t_www.Text = "Strona www";
            this.t_www.Click += new System.EventHandler(this.WebPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_text});
            this.statusStrip1.Location = new System.Drawing.Point(3, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_text
            // 
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(165, 17);
            this.status_text.Text = "Aby uzyskać pomoc, kliknij F1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_drukuj,
            this.t_podglad,
            this.toolStripSeparator,
            this.t_pierwszy,
            this.t_poprzedni,
            this.t_nastepny,
            this.t_ostatni,
            this.toolStripSeparator1,
            this.t_dodaj,
            this.t_edycja,
            this.t_usun,
            this.t_szukaj,
            this.toolStripSeparator2,
            this.t_pomoc});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(668, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // t_drukuj
            // 
            this.t_drukuj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_drukuj.Image = ((System.Drawing.Image)(resources.GetObject("t_drukuj.Image")));
            this.t_drukuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_drukuj.Name = "t_drukuj";
            this.t_drukuj.Size = new System.Drawing.Size(23, 22);
            this.t_drukuj.Text = "&Drukuj";
            this.t_drukuj.Click += new System.EventHandler(this.drukuj_Click);
            // 
            // t_podglad
            // 
            this.t_podglad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_podglad.Image = ((System.Drawing.Image)(resources.GetObject("t_podglad.Image")));
            this.t_podglad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_podglad.Name = "t_podglad";
            this.t_podglad.Size = new System.Drawing.Size(23, 22);
            this.t_podglad.Text = "Podgląd";
            this.t_podglad.Click += new System.EventHandler(this.podglad_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // t_pierwszy
            // 
            this.t_pierwszy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_pierwszy.Image = ((System.Drawing.Image)(resources.GetObject("t_pierwszy.Image")));
            this.t_pierwszy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_pierwszy.Name = "t_pierwszy";
            this.t_pierwszy.Size = new System.Drawing.Size(23, 22);
            this.t_pierwszy.Text = "Pierwszy";
            this.t_pierwszy.Click += new System.EventHandler(this.first);
            // 
            // t_poprzedni
            // 
            this.t_poprzedni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_poprzedni.Image = ((System.Drawing.Image)(resources.GetObject("t_poprzedni.Image")));
            this.t_poprzedni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_poprzedni.Name = "t_poprzedni";
            this.t_poprzedni.Size = new System.Drawing.Size(23, 22);
            this.t_poprzedni.Text = "Poprzedni";
            this.t_poprzedni.Click += new System.EventHandler(this.prev);
            // 
            // t_nastepny
            // 
            this.t_nastepny.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_nastepny.Image = ((System.Drawing.Image)(resources.GetObject("t_nastepny.Image")));
            this.t_nastepny.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_nastepny.Name = "t_nastepny";
            this.t_nastepny.Size = new System.Drawing.Size(23, 22);
            this.t_nastepny.Text = "Następny";
            this.t_nastepny.Click += new System.EventHandler(this.next);
            // 
            // t_ostatni
            // 
            this.t_ostatni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_ostatni.Image = ((System.Drawing.Image)(resources.GetObject("t_ostatni.Image")));
            this.t_ostatni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_ostatni.Name = "t_ostatni";
            this.t_ostatni.Size = new System.Drawing.Size(23, 22);
            this.t_ostatni.Text = "Ostatni";
            this.t_ostatni.Click += new System.EventHandler(this.last);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // t_dodaj
            // 
            this.t_dodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_dodaj.Image = ((System.Drawing.Image)(resources.GetObject("t_dodaj.Image")));
            this.t_dodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_dodaj.Name = "t_dodaj";
            this.t_dodaj.Size = new System.Drawing.Size(23, 22);
            this.t_dodaj.Text = "Dodaj";
            this.t_dodaj.Click += new System.EventHandler(this.nowy);
            // 
            // t_edycja
            // 
            this.t_edycja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_edycja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_aktualizuj,
            this.t_dodjaknow});
            this.t_edycja.Image = ((System.Drawing.Image)(resources.GetObject("t_edycja.Image")));
            this.t_edycja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_edycja.Name = "t_edycja";
            this.t_edycja.Size = new System.Drawing.Size(29, 22);
            this.t_edycja.Text = "Edytuj";
            // 
            // t_aktualizuj
            // 
            this.t_aktualizuj.Name = "t_aktualizuj";
            this.t_aktualizuj.Size = new System.Drawing.Size(176, 22);
            this.t_aktualizuj.Text = "&Aktualizuj";
            this.t_aktualizuj.Click += new System.EventHandler(this.aktualizuj);
            // 
            // t_dodjaknow
            // 
            this.t_dodjaknow.Name = "t_dodjaknow";
            this.t_dodjaknow.Size = new System.Drawing.Size(176, 22);
            this.t_dodjaknow.Text = "&Dodaj jako nowego";
            this.t_dodjaknow.Click += new System.EventHandler(this.addasnew);
            // 
            // t_usun
            // 
            this.t_usun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_usun.Image = ((System.Drawing.Image)(resources.GetObject("t_usun.Image")));
            this.t_usun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_usun.Name = "t_usun";
            this.t_usun.Size = new System.Drawing.Size(23, 22);
            this.t_usun.Text = "Usuń";
            this.t_usun.Click += new System.EventHandler(this.usun);
            // 
            // t_szukaj
            // 
            this.t_szukaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_szukaj.Image = ((System.Drawing.Image)(resources.GetObject("t_szukaj.Image")));
            this.t_szukaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_szukaj.Name = "t_szukaj";
            this.t_szukaj.Size = new System.Drawing.Size(23, 22);
            this.t_szukaj.Text = "Szukaj";
            this.t_szukaj.Click += new System.EventHandler(this.searchclick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_pomoc
            // 
            this.t_pomoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_pomoc.Image = ((System.Drawing.Image)(resources.GetObject("t_pomoc.Image")));
            this.t_pomoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t_pomoc.Name = "t_pomoc";
            this.t_pomoc.Size = new System.Drawing.Size(23, 22);
            this.t_pomoc.Text = "Pomoc";
            this.t_pomoc.Click += new System.EventHandler(this.pomoc);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // sqliteSelectCommand1
            // 
            this.sqliteSelectCommand1.CommandText = null;
            // 
            // sqliteInsertCommand1
            // 
            this.sqliteInsertCommand1.CommandText = null;
            // 
            // sqliteUpdateCommand1
            // 
            this.sqliteUpdateCommand1.CommandText = null;
            // 
            // sqliteDeleteCommand1
            // 
            this.sqliteDeleteCommand1.CommandText = null;
            // 
            // sqLiteDataAdapter1
            // 
            this.sqLiteDataAdapter1.DeleteCommand = this.sqliteDeleteCommand1;
            this.sqLiteDataAdapter1.InsertCommand = this.sqliteInsertCommand1;
            this.sqLiteDataAdapter1.SelectCommand = this.sqliteSelectCommand1;
            this.sqLiteDataAdapter1.UpdateCommand = this.sqliteUpdateCommand1;
            // 
            // tooltip
            // 
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Informacja";
            // 
            // peselWarning
            // 
            this.peselWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.peselWarning.ToolTipTitle = "Niedozwolony znak!";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(57, 110);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(165, 20);
            this.FindTextBox.TabIndex = 8;
            this.FindTextBox.Visible = false;
            // 
            // buttonfind
            // 
            this.buttonfind.Location = new System.Drawing.Point(72, 168);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(75, 23);
            this.buttonfind.TabIndex = 9;
            this.buttonfind.Text = "Szukaj";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Visible = false;
            this.buttonfind.Click += new System.EventHandler(this.buttonfind_Click);
            // 
            // u_pesel
            // 
            this.u_pesel.AllowSpace = false;
            this.u_pesel.Location = new System.Drawing.Point(114, 184);
            this.u_pesel.MaxLength = 11;
            this.u_pesel.Name = "u_pesel";
            this.u_pesel.Size = new System.Drawing.Size(129, 20);
            this.u_pesel.TabIndex = 12;
            this.tooltip.SetToolTip(this.u_pesel, "Pesel pacjenta drukowany na recepcie\r\nTo pole może zawierać tylko cyfry\r\nbez spac" +
                    "ji, przecinków czy innych znaków");
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 495);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rcp_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.rcp_menu;
            this.Name = "main_form";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.Text = "Receptka";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rcp_menu.ResumeLayout(false);
            this.rcp_menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button u_anuluj;
        private System.Windows.Forms.Button u_dodjaknow;
        private System.Windows.Forms.Button u_zapisz;
        private System.Windows.Forms.Button u_aktualizuj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox u_kch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private NumericTextBox u_pesel;
        private System.Windows.Forms.TextBox u_adres;
        private System.Windows.Forms.TextBox u_nazwisko;
        private System.Windows.Forms.TextBox u_imie;
        private System.Windows.Forms.MenuStrip rcp_menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacjentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel status_text;
        private System.Windows.Forms.ToolStripButton t_drukuj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton t_podglad;
        private System.Windows.Forms.ToolStripButton t_pierwszy;
        private System.Windows.Forms.ToolStripButton t_poprzedni;
        private System.Windows.Forms.ToolStripButton t_nastepny;
        private System.Windows.Forms.ToolStripButton t_ostatni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton t_dodaj;
        private System.Windows.Forms.ToolStripDropDownButton t_edycja;
        private System.Windows.Forms.ToolStripMenuItem t_aktualizuj;
        private System.Windows.Forms.ToolStripMenuItem t_dodjaknow;
        private System.Windows.Forms.ToolStripButton t_usun;
        private System.Windows.Forms.ToolStripButton t_szukaj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton t_pomoc;
        private System.Windows.Forms.ToolStripMenuItem m_wyjscie;
        private System.Windows.Forms.ToolStripMenuItem m_drukuj;
        private System.Windows.Forms.ToolStripMenuItem m_podglad;
        private System.Windows.Forms.ToolStripMenuItem m_pierwszy;
        private System.Windows.Forms.ToolStripMenuItem m_poprzedni;
        private System.Windows.Forms.ToolStripMenuItem m_nastepny;
        private System.Windows.Forms.ToolStripMenuItem m_ostatni;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem m_dodaj;
        private System.Windows.Forms.ToolStripMenuItem m_edycja;
        private System.Windows.Forms.ToolStripMenuItem m_aktualizuj;
        private System.Windows.Forms.ToolStripMenuItem m_dodjaknow;
        private System.Windows.Forms.ToolStripMenuItem m_usun;
        private System.Windows.Forms.ToolStripMenuItem m_szukaj;
        private System.Windows.Forms.ToolStripMenuItem m_pomoc;
        private System.Windows.Forms.ToolStripMenuItem m_informacje;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem t_www;
        private System.Data.SQLite.SQLiteCommand sqliteSelectCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteInsertCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteUpdateCommand1;
        private System.Data.SQLite.SQLiteCommand sqliteDeleteCommand1;
        private System.Data.SQLite.SQLiteDataAdapter sqLiteDataAdapter1;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolTip peselWarning;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.TextBox FindTextBox;

    }
}

