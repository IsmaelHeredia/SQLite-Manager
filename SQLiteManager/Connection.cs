﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace SQLiteManager
{
    class Connection
    {
        public SQLiteConnection connection;
        public SQLiteCommand command;
        public SQLiteDataReader dr;
        public DataTable dt;

        public Connection()
        {
            connection = new SQLiteConnection();
            command = new SQLiteCommand();
            dt = new DataTable();
            dr = null;
        }

        public void open(string db_name)
        {
            connection.ConnectionString = "Data Source = " + db_name + "; Version = 3; New = True; Compress = True;";
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            command.Connection = connection;
        }
        public void close()
        {
            connection.Close();
        }
    }
}
