using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Receptka
{
    class DBModule
    {
        SQLiteConnection conn = null;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        /// <summary>
        /// Funkcja inicjalizująca bazę danych SQLite
        /// </summary>
        public void init()
        {
            try
            {
                conn = new SQLiteConnection("Data Source = pacjenci.s3db;");
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie można zainicjalizować bazy danych.\r\n" +
                   "Oryginalna treść błędu: \r\n" + e.Message, "Receptka - Błąd bazy danych");
            }
            string CommandText = "select * from dane";
            DB = new SQLiteDataAdapter(CommandText, conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            
        }

        /// <summary>
        /// Wykonuje zapytanie SQL
        /// </summary>
        /// <param name="sql">Treść zapytania</param>
        /// <returns>Num rows updated</returns>
        public int ExecuteNonQuery(string sql)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            
            int rowsUpdated = cmd.ExecuteNonQuery();
            return rowsUpdated;
        }

        /// <summary>
        /// Wykonuje zapytanie SQL jakoś inaczej
        /// </summary>
        /// <param name="sql">treść zapytania</param>
        /// <returns>może coś zwrócić</returns>
        public string ExecuteScalar(string sql)
        {

            SQLiteCommand mycommand = new SQLiteCommand(conn);

            mycommand.CommandText = sql;

            object value = mycommand.ExecuteScalar();

            if (value != null)
            {

                return value.ToString();

            }

            return "";

        }

        /// <summary>
        /// Zwraca ilość rekordów
        /// </summary>
        /// <returns>zwraca ilość rekordów</returns>
        public int NumRows()
        {
            return DT.Rows.Count;
        }

        /// <summary>
        /// Czyta wartość podanej kolumny
        /// </summary>
        /// <param name="sql">zapytanie o który wiersz chodzi</param>
        /// <param name="col">nazwa kolumny do odczytu</param>
        /// <returns>zawartość kolumny, należy ją przekształcić</returns>
        public object ExecuteReader(string sql, string col)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
           
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();

           return reader[col];
        }

        /// <summary>
        /// Zamyka połączenie z bazą
        /// </summary>
        public void ConnClose()
        {
            conn.Close();
        }
    }
}
