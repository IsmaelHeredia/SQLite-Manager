namespace SQLiteManager
{
    partial class FormHome
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.miFile = new Telerik.WinControls.UI.RadMenuItem();
            this.miNewDatabase = new Telerik.WinControls.UI.RadMenuItem();
            this.miOpenDatabase = new Telerik.WinControls.UI.RadMenuItem();
            this.miAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.miExit = new Telerik.WinControls.UI.RadMenuItem();
            this.ssStatus = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.gbTables = new Telerik.WinControls.UI.RadGroupBox();
            this.tvTables = new Telerik.WinControls.UI.RadTreeView();
            this.pvOptions = new Telerik.WinControls.UI.RadPageView();
            this.pvSelect = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblRowsCount = new Telerik.WinControls.UI.RadLabel();
            this.txtQuerySelect = new Telerik.WinControls.UI.RadTextBoxControl();
            this.gvData = new Telerik.WinControls.UI.RadGridView();
            this.btnExecuteSelect = new Telerik.WinControls.UI.RadButton();
            this.lblQuerySelect = new Telerik.WinControls.UI.RadLabel();
            this.pvDataManipulation = new Telerik.WinControls.UI.RadPageViewPage();
            this.btnExecuteData = new Telerik.WinControls.UI.RadButton();
            this.txtQueryData = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtConsoleData = new Telerik.WinControls.UI.RadTextBoxControl();
            this.lblQueryData = new Telerik.WinControls.UI.RadLabel();
            this.mOptions = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.ssStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTables)).BeginInit();
            this.gbTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvOptions)).BeginInit();
            this.pvOptions.SuspendLayout();
            this.pvSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuerySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecuteSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuerySelect)).BeginInit();
            this.pvDataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecuteData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsoleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQueryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // miFile
            // 
            this.miFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miNewDatabase,
            this.miOpenDatabase});
            this.miFile.Name = "miFile";
            this.miFile.Text = "File";
            // 
            // miNewDatabase
            // 
            this.miNewDatabase.Name = "miNewDatabase";
            this.miNewDatabase.Text = "New database";
            this.miNewDatabase.Click += new System.EventHandler(this.miNewDatabase_Click);
            // 
            // miOpenDatabase
            // 
            this.miOpenDatabase.Name = "miOpenDatabase";
            this.miOpenDatabase.Text = "Load database";
            this.miOpenDatabase.Click += new System.EventHandler(this.miOpenDatabase_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Text = "About";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 519);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(717, 25);
            this.ssStatus.TabIndex = 3;
            this.ssStatus.Text = "radStatusStrip1";
            this.ssStatus.ThemeName = "TelerikMetro";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.ssStatus.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextWrap = true;
            // 
            // gbTables
            // 
            this.gbTables.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbTables.Controls.Add(this.tvTables);
            this.gbTables.HeaderText = "Tables";
            this.gbTables.Location = new System.Drawing.Point(12, 44);
            this.gbTables.Name = "gbTables";
            this.gbTables.Size = new System.Drawing.Size(252, 445);
            this.gbTables.TabIndex = 4;
            this.gbTables.Text = "Tables";
            this.gbTables.ThemeName = "TelerikMetro";
            // 
            // tvTables
            // 
            this.tvTables.Location = new System.Drawing.Point(22, 31);
            this.tvTables.Name = "tvTables";
            this.tvTables.Size = new System.Drawing.Size(210, 393);
            this.tvTables.SpacingBetweenNodes = -1;
            this.tvTables.TabIndex = 1;
            this.tvTables.Text = "radTreeView1";
            this.tvTables.ThemeName = "TelerikMetro";
            // 
            // pvOptions
            // 
            this.pvOptions.Controls.Add(this.pvSelect);
            this.pvOptions.Controls.Add(this.pvDataManipulation);
            this.pvOptions.Location = new System.Drawing.Point(280, 44);
            this.pvOptions.Name = "pvOptions";
            this.pvOptions.SelectedPage = this.pvSelect;
            this.pvOptions.Size = new System.Drawing.Size(425, 445);
            this.pvOptions.TabIndex = 5;
            this.pvOptions.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvOptions.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // pvSelect
            // 
            this.pvSelect.Controls.Add(this.lblRowsCount);
            this.pvSelect.Controls.Add(this.txtQuerySelect);
            this.pvSelect.Controls.Add(this.gvData);
            this.pvSelect.Controls.Add(this.btnExecuteSelect);
            this.pvSelect.Controls.Add(this.lblQuerySelect);
            this.pvSelect.ItemSize = new System.Drawing.SizeF(45F, 25F);
            this.pvSelect.Location = new System.Drawing.Point(5, 31);
            this.pvSelect.Name = "pvSelect";
            this.pvSelect.Size = new System.Drawing.Size(415, 409);
            this.pvSelect.Text = "Select";
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.Location = new System.Drawing.Point(17, 375);
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(79, 18);
            this.lblRowsCount.TabIndex = 5;
            this.lblRowsCount.Text = "Rows count : 0";
            // 
            // txtQuerySelect
            // 
            this.txtQuerySelect.AcceptsReturn = true;
            this.txtQuerySelect.Location = new System.Drawing.Point(17, 37);
            this.txtQuerySelect.Multiline = true;
            this.txtQuerySelect.Name = "txtQuerySelect";
            this.txtQuerySelect.Size = new System.Drawing.Size(384, 59);
            this.txtQuerySelect.TabIndex = 4;
            this.txtQuerySelect.ThemeName = "TelerikMetro";
            this.txtQuerySelect.VerticalScrollBarState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.txtQuerySelect.WordWrap = false;
            // 
            // gvData
            // 
            this.gvData.Location = new System.Drawing.Point(17, 165);
            // 
            // 
            // 
            this.gvData.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gvData.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gvData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvData.Name = "gvData";
            this.gvData.ReadOnly = true;
            this.gvData.Size = new System.Drawing.Size(384, 191);
            this.gvData.TabIndex = 3;
            this.gvData.Text = "radGridView1";
            this.gvData.ThemeName = "TelerikMetro";
            // 
            // btnExecuteSelect
            // 
            this.btnExecuteSelect.Location = new System.Drawing.Point(165, 113);
            this.btnExecuteSelect.Name = "btnExecuteSelect";
            this.btnExecuteSelect.Size = new System.Drawing.Size(75, 24);
            this.btnExecuteSelect.TabIndex = 2;
            this.btnExecuteSelect.Text = "Execute";
            this.btnExecuteSelect.ThemeName = "TelerikMetro";
            this.btnExecuteSelect.Click += new System.EventHandler(this.btnExecuteSelect_Click);
            // 
            // lblQuerySelect
            // 
            this.lblQuerySelect.Location = new System.Drawing.Point(17, 12);
            this.lblQuerySelect.Name = "lblQuerySelect";
            this.lblQuerySelect.Size = new System.Drawing.Size(45, 18);
            this.lblQuerySelect.TabIndex = 0;
            this.lblQuerySelect.Text = "Query : ";
            // 
            // pvDataManipulation
            // 
            this.pvDataManipulation.Controls.Add(this.btnExecuteData);
            this.pvDataManipulation.Controls.Add(this.txtQueryData);
            this.pvDataManipulation.Controls.Add(this.txtConsoleData);
            this.pvDataManipulation.Controls.Add(this.lblQueryData);
            this.pvDataManipulation.ItemSize = new System.Drawing.SizeF(114F, 25F);
            this.pvDataManipulation.Location = new System.Drawing.Point(5, 31);
            this.pvDataManipulation.Name = "pvDataManipulation";
            this.pvDataManipulation.Size = new System.Drawing.Size(415, 409);
            this.pvDataManipulation.Text = "Data Manipulation";
            // 
            // btnExecuteData
            // 
            this.btnExecuteData.Location = new System.Drawing.Point(157, 193);
            this.btnExecuteData.Name = "btnExecuteData";
            this.btnExecuteData.Size = new System.Drawing.Size(110, 24);
            this.btnExecuteData.TabIndex = 9;
            this.btnExecuteData.Text = "Execute";
            this.btnExecuteData.ThemeName = "TelerikMetro";
            this.btnExecuteData.Click += new System.EventHandler(this.btnExecuteData_Click);
            // 
            // txtQueryData
            // 
            this.txtQueryData.AcceptsReturn = true;
            this.txtQueryData.Location = new System.Drawing.Point(18, 51);
            this.txtQueryData.Multiline = true;
            this.txtQueryData.Name = "txtQueryData";
            this.txtQueryData.Size = new System.Drawing.Size(384, 121);
            this.txtQueryData.TabIndex = 8;
            this.txtQueryData.ThemeName = "TelerikMetro";
            this.txtQueryData.VerticalScrollBarState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.txtQueryData.WordWrap = false;
            // 
            // txtConsoleData
            // 
            this.txtConsoleData.IsReadOnly = true;
            this.txtConsoleData.Location = new System.Drawing.Point(18, 242);
            this.txtConsoleData.Name = "txtConsoleData";
            this.txtConsoleData.Size = new System.Drawing.Size(384, 151);
            this.txtConsoleData.TabIndex = 7;
            this.txtConsoleData.ThemeName = "TelerikMetro";
            // 
            // lblQueryData
            // 
            this.lblQueryData.Location = new System.Drawing.Point(18, 21);
            this.lblQueryData.Name = "lblQueryData";
            this.lblQueryData.Size = new System.Drawing.Size(49, 19);
            this.lblQueryData.TabIndex = 3;
            this.lblQueryData.Text = "Query : ";
            this.lblQueryData.ThemeName = "TelerikMetro";
            // 
            // mOptions
            // 
            this.mOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miFile,
            this.miAbout,
            this.miExit});
            this.mOptions.Location = new System.Drawing.Point(0, 0);
            this.mOptions.Name = "mOptions";
            this.mOptions.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.mOptions.Size = new System.Drawing.Size(717, 29);
            this.mOptions.TabIndex = 2;
            this.mOptions.ThemeName = "TelerikMetro";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 544);
            this.Controls.Add(this.pvOptions);
            this.Controls.Add(this.gbTables);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.mOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SQLite Manager 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ssStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTables)).EndInit();
            this.gbTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvOptions)).EndInit();
            this.pvOptions.ResumeLayout(false);
            this.pvSelect.ResumeLayout(false);
            this.pvSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuerySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecuteSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuerySelect)).EndInit();
            this.pvDataManipulation.ResumeLayout(false);
            this.pvDataManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecuteData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsoleData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQueryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadMenuItem miFile;
        private Telerik.WinControls.UI.RadMenuItem miNewDatabase;
        private Telerik.WinControls.UI.RadMenuItem miOpenDatabase;
        private Telerik.WinControls.UI.RadMenuItem miAbout;
        private Telerik.WinControls.UI.RadMenuItem miExit;
        private Telerik.WinControls.UI.RadMenu mOptions;
        private Telerik.WinControls.UI.RadStatusStrip ssStatus;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadGroupBox gbTables;
        private Telerik.WinControls.UI.RadTreeView tvTables;
        private Telerik.WinControls.UI.RadPageView pvOptions;
        private Telerik.WinControls.UI.RadPageViewPage pvSelect;
        private Telerik.WinControls.UI.RadPageViewPage pvDataManipulation;
        private Telerik.WinControls.UI.RadLabel lblQuerySelect;
        private Telerik.WinControls.UI.RadButton btnExecuteSelect;
        private Telerik.WinControls.UI.RadGridView gvData;
        private Telerik.WinControls.UI.RadLabel lblQueryData;
        private Telerik.WinControls.UI.RadTextBoxControl txtConsoleData;
        private Telerik.WinControls.UI.RadTextBoxControl txtQuerySelect;
        private Telerik.WinControls.UI.RadTextBoxControl txtQueryData;
        private Telerik.WinControls.UI.RadLabel lblRowsCount;
        private Telerik.WinControls.UI.RadButton btnExecuteData;
    }
}