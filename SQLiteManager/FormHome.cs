// SQLite Manager 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.SQLite;
using System.Configuration;
using System.IO;

namespace SQLiteManager
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        public string db_name = "";
        public string program_title;

        public FormHome()
        {
            InitializeComponent();

            program_title = System.Configuration.ConfigurationManager.AppSettings["program_title"];

            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public string loadNameFile(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            return fi.Name;
        }

        public void sendStatus(string text)
        {
            lblStatus.Text = text;
            ssStatus.LayoutManager.UpdateLayout();
            ssStatus.Refresh();
        }

        public void loadTables()
        {
            tvTables.Nodes.Clear();
            DataAccess da = new DataAccess(db_name);
            ArrayList tables = da.listTables();
            foreach (string table in tables)
            {
                RadTreeNode node = tvTables.Nodes.Add(table);
                ArrayList columns = da.listColumns(table);
                foreach (string column in columns)
                {
                    node.Nodes.Add(column);
                }
            }
        }

        public void cleanData()
        {
            tvTables.Nodes.Clear();
            txtQuerySelect.Text = "";
            gvData.DataSource = null;
            gvData.Rows.Clear();
            txtQueryData.Text = "";
            txtConsoleData.Text = "";
            lblRowsCount.Text = "Rows count : 0";
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;

            this.DragEnter += new DragEventHandler(Form_DragEnter);
            this.DragDrop += new DragEventHandler(Form_DragDrop);
        }

        public void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public void Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string filename = FileList[0];
            FileInfo fi = new FileInfo(filename);
            string ext = fi.Extension;
            if (ext == ".sqlite3")
            {
                db_name = filename;
                sendStatus("Working with " + loadNameFile(db_name));
                cleanData();
                loadTables();
            }
            else
            {
                RadMessageBox.Show("Select SQLite database", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void miNewDatabase_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Save SQLite File";
            saveFileDialog.DefaultExt = "sqlite3";
            saveFileDialog.Filter = "SQLite File (.sqlite3)|*.sqlite3";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                db_name = saveFileDialog.FileName;
                cleanData();
                sendStatus("Working with " + loadNameFile(db_name));
            }
        }

        private void miOpenDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Load SQLite file";
            openFileDialog.DefaultExt = "sqlite3";
            openFileDialog.Filter = "SQLite File (.sqlite3)|*.sqlite3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                db_name = openFileDialog.FileName;
                cleanData();
                loadTables();
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Copyright © Ismael Heredia 2020", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecuteSelect_Click(object sender, EventArgs e)
        {
            if (db_name != "")
            {
                string query = txtQuerySelect.Text;

                try
                {
                    Connection connection = new Connection();
                    connection.open(db_name);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection.connection);
                    DataSet ds = new System.Data.DataSet();

                    dataAdapter.Fill(ds, "Info");
                    gvData.DataSource = ds.Tables[0];
                    connection.close();

                    this.gvData.BestFitColumns();

                    lblRowsCount.Text = "Rows count : " + gvData.RowCount;
                }
                catch
                {
                    RadMessageBox.Show("Bad sintax", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                RadMessageBox.Show("Select database", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExecuteData_Click(object sender, EventArgs e)
        {
            if (db_name != "")
            {
                string sql = txtQueryData.Text;

                try
                {
                    Connection connection = new Connection();
                    connection.open(db_name);

                    connection.command.CommandText = sql;
                    int rows = connection.command.ExecuteNonQuery();

                    txtConsoleData.Text = "Affected rows : " + rows;

                    connection.close();

                    loadTables();
                }
                catch
                {
                    RadMessageBox.Show("Bad sintax", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                RadMessageBox.Show("Select database", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Are you sure ?", program_title, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() != "Yes")
            {
                e.Cancel = true;
                this.Activate();
            }
        }
    }
}
