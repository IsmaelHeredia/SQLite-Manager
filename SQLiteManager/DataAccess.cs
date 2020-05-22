using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace SQLiteManager
{
    class DataAccess
    {
        public string db_name = "";

        public DataAccess(string load_db_name)
        {
            db_name = load_db_name;
        }

        public ArrayList listTables()
        {
            ArrayList listTables = new ArrayList();

            Connection connection = new Connection();
            connection.open(db_name);

            var query = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type ='table' AND name NOT LIKE 'sqlite_%';", connection.connection);

            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    string table_name = reader.GetString(0);
                    listTables.Add(table_name);
                } 
            }

            reader.Close();
            connection.close();

            return listTables;
        }

        public ArrayList listColumns(string table)
        {
            ArrayList listColumns = new ArrayList();

            Connection connection = new Connection();
            connection.open(db_name);

            var query = new SQLiteCommand("SELECT * FROM " + table, connection.connection);

            var reader = query.ExecuteReader();

            for (var i = 0; i < reader.FieldCount; i++)
            {
                listColumns.Add(reader.GetName(i) + " : " + reader.GetFieldType(i));
            }

            reader.Close();
            connection.close();

            return listColumns;
        }
    }
}
