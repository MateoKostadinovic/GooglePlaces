namespace GooglePlaces
{
    public partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddType = new System.Windows.Forms.Button();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Location = new System.Drawing.Point(13, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(793, 290);
            this.tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.dataGridViewLocations);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.comboBoxCity);
            this.tabPage1.Controls.Add(this.trackBarRadius);
            this.tabPage1.Controls.Add(this.lblRadius);
            this.tabPage1.Controls.Add(this.lblType);
            this.tabPage1.Controls.Add(this.lblCity);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pretraga";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(103, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewLocations
            // 
            this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocations.Location = new System.Drawing.Point(283, 49);
            this.dataGridViewLocations.Name = "dataGridViewLocations";
            this.dataGridViewLocations.Size = new System.Drawing.Size(465, 196);
            this.dataGridViewLocations.TabIndex = 6;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(103, 100);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 5;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(103, 49);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 4;
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(103, 156);
            this.trackBarRadius.Maximum = 50000;
            this.trackBarRadius.Minimum = 1;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(121, 45);
            this.trackBarRadius.TabIndex = 3;
            this.trackBarRadius.Value = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(20, 156);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(38, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(22, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Tip";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(30, 58);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Grad";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Moje lokacije";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddType);
            this.tabPage3.Controls.Add(this.dataGridViewTypes);
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administracija tipova";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.DimGray;
            this.btnAddType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddType.Location = new System.Drawing.Point(460, 6);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(118, 37);
            this.btnAddType.TabIndex = 1;
            this.btnAddType.Text = "Dodaj tip";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.Size = new System.Drawing.Size(395, 252);
            this.dataGridViewTypes.TabIndex = 0;
            this.dataGridViewTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTypes_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAddCity);
            this.tabPage4.Controls.Add(this.dataGridViewCities);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(785, 264);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administracija gradova";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.DimGray;
            this.btnAddCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCity.Location = new System.Drawing.Point(572, 6);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(118, 37);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Dodaj grad";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(520, 252);
            this.dataGridViewCities.TabIndex = 1;
            this.dataGridViewCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCities_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 322);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dataGridViewLocations;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.ComboBox comboBoxCity;
        public System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddType;
        public System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAddCity;
        public System.Windows.Forms.DataGridView dataGridViewCities;
    }
}

