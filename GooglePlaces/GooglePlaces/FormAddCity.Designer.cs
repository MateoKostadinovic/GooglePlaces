namespace GooglePlaces
{
    partial class FormAddCity
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
            this.lblAddCityName = new System.Windows.Forms.Label();
            this.lblAddCityLat = new System.Windows.Forms.Label();
            this.lblAddCityLng = new System.Windows.Forms.Label();
            this.inptAddCityName = new System.Windows.Forms.TextBox();
            this.inptAddCityLat = new System.Windows.Forms.TextBox();
            this.inptAddCityLng = new System.Windows.Forms.TextBox();
            this.btnAddCity2 = new System.Windows.Forms.Button();
            this.latview = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddCityName
            // 
            this.lblAddCityName.AutoSize = true;
            this.lblAddCityName.Location = new System.Drawing.Point(40, 51);
            this.lblAddCityName.Name = "lblAddCityName";
            this.lblAddCityName.Size = new System.Drawing.Size(53, 13);
            this.lblAddCityName.TabIndex = 0;
            this.lblAddCityName.Text = "City name";
            // 
            // lblAddCityLat
            // 
            this.lblAddCityLat.AutoSize = true;
            this.lblAddCityLat.Location = new System.Drawing.Point(48, 104);
            this.lblAddCityLat.Name = "lblAddCityLat";
            this.lblAddCityLat.Size = new System.Drawing.Size(45, 13);
            this.lblAddCityLat.TabIndex = 1;
            this.lblAddCityLat.Text = "Latitude";
            // 
            // lblAddCityLng
            // 
            this.lblAddCityLng.AutoSize = true;
            this.lblAddCityLng.Location = new System.Drawing.Point(39, 153);
            this.lblAddCityLng.Name = "lblAddCityLng";
            this.lblAddCityLng.Size = new System.Drawing.Size(54, 13);
            this.lblAddCityLng.TabIndex = 2;
            this.lblAddCityLng.Text = "Longitude";
            // 
            // inptAddCityName
            // 
            this.inptAddCityName.Location = new System.Drawing.Point(164, 51);
            this.inptAddCityName.Name = "inptAddCityName";
            this.inptAddCityName.Size = new System.Drawing.Size(178, 20);
            this.inptAddCityName.TabIndex = 3;
            // 
            // inptAddCityLat
            // 
            this.inptAddCityLat.Location = new System.Drawing.Point(164, 104);
            this.inptAddCityLat.Name = "inptAddCityLat";
            this.inptAddCityLat.Size = new System.Drawing.Size(178, 20);
            this.inptAddCityLat.TabIndex = 4;
            // 
            // inptAddCityLng
            // 
            this.inptAddCityLng.Location = new System.Drawing.Point(164, 153);
            this.inptAddCityLng.Name = "inptAddCityLng";
            this.inptAddCityLng.Size = new System.Drawing.Size(178, 20);
            this.inptAddCityLng.TabIndex = 5;
            // 
            // btnAddCity2
            // 
            this.btnAddCity2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddCity2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCity2.Location = new System.Drawing.Point(164, 199);
            this.btnAddCity2.Name = "btnAddCity2";
            this.btnAddCity2.Size = new System.Drawing.Size(178, 41);
            this.btnAddCity2.TabIndex = 6;
            this.btnAddCity2.Text = "Add";
            this.btnAddCity2.UseVisualStyleBackColor = false;
            this.btnAddCity2.Click += new System.EventHandler(this.btnAddCity2_Click);
            // 
            // latview
            // 
            this.latview.Location = new System.Drawing.Point(42, 182);
            this.latview.Name = "latview";
            this.latview.Size = new System.Drawing.Size(100, 20);
            this.latview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TEST";
            // 
            // FormAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latview);
            this.Controls.Add(this.btnAddCity2);
            this.Controls.Add(this.inptAddCityLng);
            this.Controls.Add(this.inptAddCityLat);
            this.Controls.Add(this.inptAddCityName);
            this.Controls.Add(this.lblAddCityLng);
            this.Controls.Add(this.lblAddCityLat);
            this.Controls.Add(this.lblAddCityName);
            this.Name = "FormAddCity";
            this.Text = "Dodavanje grada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCityName;
        private System.Windows.Forms.Label lblAddCityLat;
        private System.Windows.Forms.Label lblAddCityLng;
        private System.Windows.Forms.TextBox inptAddCityName;
        private System.Windows.Forms.TextBox inptAddCityLat;
        private System.Windows.Forms.TextBox inptAddCityLng;
        private System.Windows.Forms.Button btnAddCity2;
        private System.Windows.Forms.TextBox latview;
        private System.Windows.Forms.Label label1;
    }
}