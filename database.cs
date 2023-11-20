using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;

namespace Home_accounting
{    
    public class Database
    {
        public SQLiteConnection sqlite;
        public SQLiteCommand command;
        public String query;
        public DbDataReader reader;
        public Database()
        {
            sqlite = new SQLiteConnection("Data Source=home_acc.db");
            sqlite.Open();
        }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter();

            try
            {                
                command = new SQLiteCommand(query, sqlite);
                dt.Load(command.ExecuteReader());
                da.Fill(dt);
            }
            catch
            {
            }

            return dt;
        }
        public void GetDataCombo(ref ComboBox cb)
        {            
            try
            {   
                cb.DisplayMember = "Name";
                cb.ValueMember = "id";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(query, sqlite);
                DataTable table = new DataTable();
                sda.Fill(table);
                cb.DataSource = table;
            }
            catch
            {
            }
        }
        public int[] GetDataTotal()
        {
            int[] ret = new int[3];
            try
            {
                int i1 = 0, i2 = 0, i3 = 0;
                String id_inc, id_exp, sum;

                SQLiteCommand command = new SQLiteCommand(sqlite);
                command.CommandText = query;
                command.ExecuteNonQuery();

                SQLiteDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    id_inc = reader["id_incom"].ToString();
                    id_exp = reader["id_exp"].ToString();
                    sum = reader["summa"].ToString();
                    
                    if (id_inc.ToString().Trim() != "")
                    {
                        i1 += Convert.ToInt32(sum);
                       
                    }
                    if (id_exp.ToString().Trim() != "")
                    {
                        i2 += Convert.ToInt32(sum);
                    }
                }
                reader.Close();
                i3 = i1 - i2;                
                ret[0] = i1; ret[1] = i2; ret[2] = i3;                
            }
            catch
            {
            }
            return ret;
        }

        public void createTables()
        {
            SQLiteCommand command = new SQLiteCommand(sqlite);
            query = "CREATE TABLE IF NOT EXISTS balance (id INTEGER NOT NULL DEFAULT 1, " +
                "id_incom INTEGER, " +
                "name_incom TEXT, " +
                "id_exp INTEGER, " +
                "name_exp TEXT, " +
                "summa INTEGER NOT NULL, " +
                "date TEXT NOT NULL DEFAULT '01.01.2023', " +
                "desc TEXT, " +
                "PRIMARY KEY (id AUTOINCREMENT))";
            command.CommandText = query;
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS spr_expenses (id INTEGER NOT NULL DEFAULT 1," +
                "name TEXT NOT NULL, " +
                "desc TEXT, " +
                "PRIMARY KEY(id AUTOINCREMENT))";
            command.CommandText = query;
            command.ExecuteNonQuery();

            query = "CREATE TABLE IF NOT EXISTS spr_income (id INTEGER NOT NULL DEFAULT 1," +
                "name TEXT NOT NULL, " +
                "desc TEXT, " +
                "PRIMARY KEY(id AUTOINCREMENT))";
            command.CommandText = query;
            command.ExecuteNonQuery();                        
        }
    }
}
