namespace GooglePlaces
{
    partial class FormEditCity
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
            this.lblCityId = new System.Windows.Forms.Label();
            this.lblEditCityName = new System.Windows.Forms.Label();
            this.lblEditCityLat = new System.Windows.Forms.Label();
            this.lblEditCityLng = new System.Windows.Forms.Label();
            this.inptEditCityName = new System.Windows.Forms.TextBox();
            this.inptEditCityLat = new System.Windows.Forms.TextBox();
            this.inptEditCityLng = new System.Windows.Forms.TextBox();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCityId
            // 
            this.lblCityId.AutoSize = true;
            this.lblCityId.Location = new System.Drawing.Point(35, 13);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(33, 13);
            this.lblCityId.TabIndex = 0;
            this.lblCityId.Text = "CityId";
            this.lblCityId.Visible = false;
            // 
            // lblEditCityName
            // 
            this.lblEditCityName.AutoSize = true;
            this.lblEditCityName.Location = new System.Drawing.Point(48, 63);
            this.lblEditCityName.Name = "lblEditCityName";
            this.lblEditCityName.Size = new System.Drawing.Size(35, 13);
            this.lblEditCityName.TabIndex = 1;
            this.lblEditCityName.Text = "Name";
            // 
            // lblEditCityLat
            // 
            this.lblEditCityLat.AutoSize = true;
            this.lblEditCityLat.Location = new System.Drawing.Point(38, 102);
            this.lblEditCityLat.Name = "lblEditCityLat";
            this.lblEditCityLat.Size = new System.Drawing.Size(45, 13);
            this.lblEditCityLat.TabIndex = 2;
            this.lblEditCityLat.Text = "Latitude";
            // 
            // lblEditCityLng
            // 
            this.lblEditCityLng.AutoSize = true;
            this.lblEditCityLng.Location = new System.Drawing.Point(29, 143);
            this.lblEditCityLng.Name = "lblEditCityLng";
            this.lblEditCityLng.Size = new System.Drawing.Size(54, 13);
            this.lblEditCityLng.TabIndex = 3;
            this.lblEditCityLng.Text = "Longitude";
            // 
            // inptEditCityName
            // 
            this.inptEditCityName.Location = new System.Drawing.Point(146, 63);
            this.inptEditCityName.Name = "inptEditCityName";
            this.inptEditCityName.Size = new System.Drawing.Size(174, 20);
            this.inptEditCityName.TabIndex = 4;
            // 
            // inptEditCityLat
            // 
            this.inptEditCityLat.Location = new System.Drawing.Point(146, 102);
            this.inptEditCityLat.Name = "inptEditCityLat";
            this.inptEditCityLat.Size = new System.Drawing.Size(174, 20);
            this.inptEditCityLat.TabIndex = 5;
            // 
            // inptEditCityLng
            // 
            this.inptEditCityLng.Location = new System.Drawing.Point(146, 143);
            this.inptEditCityLng.Name = "inptEditCityLng";
            this.inptEditCityLng.Size = new System.Drawing.Size(174, 20);
            this.inptEditCityLng.TabIndex = 6;
            // 
            // btnEditCity
            // 
            this.btnEditCity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCity.Location = new System.Drawing.Point(146, 200);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(174, 42);
            this.btnEditCity.TabIndex = 7;
            this.btnEditCity.Text = "Save";
            this.btnEditCity.UseVisualStyleBackColor = false;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // FormEditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 268);
            this.Controls.Add(this.btnEditCity);
            this.Controls.Add(this.inptEditCityLng);
            this.Controls.Add(this.inptEditCityLat);
            this.Controls.Add(this.inptEditCityName);
            this.Controls.Add(this.lblEditCityLng);
            this.Controls.Add(this.lblEditCityLat);
            this.Controls.Add(this.lblEditCityName);
            this.Controls.Add(this.lblCityId);
            this.Name = "FormEditCity";
            this.Text = "FormEditCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCityId;
        private System.Windows.Forms.Label lblEditCityName;
        private System.Windows.Forms.Label lblEditCityLat;
        private System.Windows.Forms.Label lblEditCityLng;
        public System.Windows.Forms.TextBox inptEditCityName;
        public System.Windows.Forms.TextBox inptEditCityLat;
        public System.Windows.Forms.TextBox inptEditCityLng;
        private System.Windows.Forms.Button btnEditCity;
    }
}