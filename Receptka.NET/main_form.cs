using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Receptka
{
    public partial class main_form : Form
    {
        DBModule db;
        int record_id;
        int num;
        object[] kch_nrs = {"01", "02", "03", "04", "05", "06",
                               "07", "08", "09", "10", "11",
                               "12", "13", "14", "15", "16"};
        public main_form()
        {
            db = new DBModule();
            db.init();
            num = this.GetNumRecords();
            record_id = num;
            InitializeComponent();
            inicjalizuj();
        }
        ~main_form()
        {
            db.ConnClose();
        }
        //z baza danych
        private int GetNumRecords() { return db.NumRows(); }
        private void inicjalizuj(bool back = false)
        {
           // bool ok = false;
           // while (!ok)
            if (record_id > num) record_id = num;

                            try
                            {
                              string st =  (string) db.ExecuteReader("select * from dane where id=" + record_id, "imie");
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Problem z identyfikatorem rekordu. ID: " + record_id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             
                               /* if (back) record_id--;
                                                    else
                                                    {
                                                        if (record_id != num) record_id++;
                                                        else record_id = 1;
                                                    }*/
                                record_id = 1;
                            }
                          //  ok = true;
                   
            
            this.u_imie.Text = (string)db.ExecuteReader("SELECT imie from dane WHERE id="+record_id, "imie");
            this.u_nazwisko.Text = (string)db.ExecuteReader("SELECT nazwisko from dane WHERE id=" + record_id, "nazwisko");
            this.u_adres.Text = (string)db.ExecuteReader("SELECT adres from dane WHERE id=" + record_id, "adres");
            this.u_pesel.Text = (string)db.ExecuteReader("SELECT pesel from dane WHERE id=" + record_id, "pesel");
            this.u_kch.Text = (string)db.ExecuteReader("SELECT kch from dane WHERE id=" + record_id, "kch");

            if(record_id==1)
            {
                t_poprzedni.Enabled = false;
                t_pierwszy.Enabled = false;

                t_nastepny.Enabled = true;
                t_ostatni.Enabled = true;
            }
            else if(record_id==num)
            {
                t_ostatni.Enabled = false;
                t_nastepny.Enabled = false;

                t_poprzedni.Enabled = true;
                t_pierwszy.Enabled = true;
            }
            else
            {
                t_poprzedni.Enabled = true;
                t_pierwszy.Enabled = true;
                t_nastepny.Enabled = true;
                t_ostatni.Enabled = true;
            }
        }
        private void ustaw_all(string sql)
        {
            this.u_imie.Text = (string)db.ExecuteReader(sql, "imie");
            this.u_nazwisko.Text = (string)db.ExecuteReader(sql, "nazwisko");
            this.u_adres.Text = (string)db.ExecuteReader(sql, "adres");
            this.u_pesel.Text = (string)db.ExecuteReader(sql, "pesel");
            this.u_kch.Text = (string)db.ExecuteReader(sql, "kch");
        }
        private void nowy(object sender, EventArgs e)
        {
            u_imie.Text = "";
            u_nazwisko.Text = "";
            u_adres.Text = "";
            u_pesel.Text = "";
            u_kch.Text = "";
            u_zapisz.Enabled = true;
            u_anuluj.Enabled = true;
            u_dodjaknow.Enabled = false;
            u_aktualizuj.Enabled = false;
        }
        private void anuluj(object sender, EventArgs e)
        {
            record_id = num;
            inicjalizuj();
            u_zapisz.Enabled = false;
            u_anuluj.Enabled = false;
            u_dodjaknow.Enabled = true;
            u_aktualizuj.Enabled = true;
        }
        private void zapisz(object sender, EventArgs e)
        {
            string sql = "insert into dane (id, imie, nazwisko, adres, pesel, kch) Values('"+(num+1)+"', '"+u_imie.Text+"', "+
                "'"+u_nazwisko.Text+"', '"+u_adres.Text+"', '"+u_pesel.Text+"', '"+u_kch.Text+"')";
            if (db.ExecuteNonQuery(sql) < 1) { MessageBox.Show("Nie udało się dodać pacjenta", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            u_zapisz.Enabled = false;
            u_anuluj.Enabled = false;
            u_dodjaknow.Enabled = true;
            u_aktualizuj.Enabled = true;
            num++;
            record_id = num;
            inicjalizuj();
        }
        private void aktualizuj(object sender, EventArgs e)
        {
            string sql = "update dane set imie='" + u_imie.Text + "', nazwisko=" +
                "'" + u_nazwisko.Text + "', adres='" + u_adres.Text + "', pesel='" + u_pesel.Text + "', kch='" + u_kch.Text + "' where dane.id="+record_id;
            if (db.ExecuteNonQuery(sql) < 1) { MessageBox.Show("Nie udało się zaktualizować danych", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            inicjalizuj();
        }
        private void usun(object sender, EventArgs e)
        {
            int temp_id;
            
                temp_id = record_id + 1;

            if (MessageBox.Show("Czy na pewno chcesz usunąć tego pacjenta?\nSpowoduje to stale uszkodzenie bazy danych", "Receptka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (db.ExecuteNonQuery("delete from dane where id=" + record_id) < 1) { MessageBox.Show("Nie udało się usunąć pacjenta", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error); };
                num--;
                for (int i = temp_id; i <= num; i++)
                {
                    db.ExecuteNonQuery("update dane set id=" + (i - 1) + " where dane.id=" + i);
                }
                inicjalizuj();
            }
        }
        public void znajdz(string tekst)
        {
            if (db.ExecuteNonQuery("select * from dane where nazwisko='" + tekst + "'") > 0)
                ustaw_all("select * from dane where nazwisko=" + tekst);
            else if (db.ExecuteNonQuery("select * from dane where pesel=" + tekst) > 0)
                ustaw_all("select * from dane where pesel=" + tekst);
            else if (db.ExecuteNonQuery("select * from dane where pesel=" + (tekst.Remove(7))) > 0)
                ustaw_all("select * from dane where pesel=" + (tekst.Remove(7)));
            else
                MessageBox.Show("Nie znaleziono pacjenta spełniającego\npodane kryteria w bazie danych", "Receptka");
        }
        private void addasnew(object sender, EventArgs e)
        {
            string sql = "insert into dane (imie, nazwisko, adres, pesel, kch) Values('" + u_imie.Text + "', " +
                "'" + u_nazwisko.Text + "', '" + u_adres.Text + "', '" + u_pesel.Text + "', '" + u_kch.Text + "')";
            if (db.ExecuteNonQuery(sql) < 1) { MessageBox.Show("Nie udało się dodać pacjenta", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error); };

            num++;
            record_id = num;
            inicjalizuj();

        }
        //nawigacja
        private void first(object sender, EventArgs e)
        {
            record_id = 1;
            inicjalizuj();
        }
        private void prev(object sender, EventArgs e)
        {
            if (record_id > 1)
            {
                record_id--;
                inicjalizuj(true);
            }
        }
        private void next(object sender, EventArgs e)
        {
            if(record_id < num)
            {
                record_id++;
                inicjalizuj();
            }
        }
        private void last(object sender, EventArgs e)
        {
            record_id = num;
            inicjalizuj();
        }
        //pozostale
        private void main_form_Load(object sender, EventArgs e)
        {
            u_kch.Items.AddRange(kch_nrs);
        }
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        private void OpenFindDialog(object sender, EventArgs e)
        {
            FindDialog dlg = new FindDialog();
            dlg.ShowDialog();
        }
        private void pomoc(object sender, EventArgs e)
        {
            Help.ShowHelp(null, "pomoc.chm");
        }
        private void WebPage(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hapex.com.pl/receptka/");
        }
        private void wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void drukuj_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float margin_x, y, right_x; //wspolrzedne
            y = 155;            //wysokosc
            margin_x = 40;      //margines lewy
            right_x = margin_x + 236;
            Font font12 = new Font("TimesNewRoman", 12);   //ustawienie czcionki na rozmiar 12
            Font font15 = new Font("TimesNewRoman", 15);   //ustawienie czcionki times new roman rozmiar 15
            Brush brush = new SolidBrush(u_imie.ForeColor);     //i pędzla
            e.Graphics.DrawString(u_imie.Text + " " + u_nazwisko.Text, font12, brush, margin_x, y); //imie i nazwisko
            if (u_kch.SelectedItem != null || u_kch.SelectedItem != null)
            {
                e.Graphics.DrawString(u_kch.SelectedItem.ToString(), font15, brush, right_x, y - 17); //kasa chorych
            }
            y += 20; //zwiekszenie odleglosci od góry o 20
            e.Graphics.DrawString(u_adres.Text, font12, brush, margin_x, y);  //adres
            y += 58; //wysokosc dla peselu
            e.Graphics.DrawString(u_pesel.Text, font12, brush, margin_x + 25, y); //pesel
        }
        private void podglad_Click(object sender, EventArgs e)
        {
            if (u_imie.Text != "" && u_nazwisko.Text != "" && u_pesel.Text != "" && u_adres.Text != "")
            {
                try
                {
                    printPreviewDialog.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie wypełniono wszystkich pól.\r\nUruchom ponownie program.\r\n"+
                    "Oryginalna treść błędu: \r\n" + ex.Message, "Receptka - Błąd");
                }
            }
            else 
            {
                MessageBox.Show("Aby podgląd był dostępny, wszystkie pola muszą być wypełnione", "Receptka"); 
            }
        }
        private void format_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }
        //wielkie litery
        private void imie_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            u_imie.Text = textInfo.ToTitleCase(u_imie.Text);
        }
        private void nazwisko_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            u_nazwisko.Text = textInfo.ToTitleCase(u_nazwisko.Text);
        }
        private void adres_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            u_adres.Text = textInfo.ToTitleCase(u_adres.Text);
        }
        private void searchclick(object sender, EventArgs e)
        {
            this.FindTextBox.Visible = true;
            this.buttonfind.Visible = true;
        }
        private void buttonfind_Click(object sender, EventArgs e)
        {
            znajdz(this.FindTextBox.Text);
            this.FindTextBox.Visible = false;
            this.buttonfind.Visible = false;
        }
    }
}
