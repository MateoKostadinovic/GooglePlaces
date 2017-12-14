namespace GooglePlaces
{
    partial class FormDeleteCity
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
            this.lblDeleteCity = new System.Windows.Forms.Label();
            this.lblDeleteCityId = new System.Windows.Forms.Label();
            this.btnDeleteCityClose = new System.Windows.Forms.Button();
            this.btnCityDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteCity
            // 
            this.lblDeleteCity.AutoSize = true;
            this.lblDeleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteCity.Location = new System.Drawing.Point(123, 38);
            this.lblDeleteCity.Name = "lblDeleteCity";
            this.lblDeleteCity.Size = new System.Drawing.Size(125, 25);
            this.lblDeleteCity.TabIndex = 0;
            this.lblDeleteCity.Text = "Delete city?";
            // 
            // lblDeleteCityId
            // 
            this.lblDeleteCityId.AutoSize = true;
            this.lblDeleteCityId.Location = new System.Drawing.Point(38, 82);
            this.lblDeleteCityId.Name = "lblDeleteCityId";
            this.lblDeleteCityId.Size = new System.Drawing.Size(33, 13);
            this.lblDeleteCityId.TabIndex = 1;
            this.lblDeleteCityId.Text = "CityId";
            this.lblDeleteCityId.Visible = false;
            // 
            // btnDeleteCityClose
            // 
            this.btnDeleteCityClose.Location = new System.Drawing.Point(12, 158);
            this.btnDeleteCityClose.Name = "btnDeleteCityClose";
            this.btnDeleteCityClose.Size = new System.Drawing.Size(158, 75);
            this.btnDeleteCityClose.TabIndex = 2;
            this.btnDeleteCityClose.Text = "Close";
            this.btnDeleteCityClose.UseVisualStyleBackColor = true;
            this.btnDeleteCityClose.Click += new System.EventHandler(this.btnDeleteCityClose_Click);
            // 
            // btnCityDelete
            // 
            this.btnCityDelete.Location = new System.Drawing.Point(193, 158);
            this.btnCityDelete.Name = "btnCityDelete";
            this.btnCityDelete.Size = new System.Drawing.Size(158, 75);
            this.btnCityDelete.TabIndex = 3;
            this.btnCityDelete.Text = "Delete";
            this.btnCityDelete.UseVisualStyleBackColor = true;
            this.btnCityDelete.Click += new System.EventHandler(this.btnCityDelete_Click);
            // 
            // FormDeleteCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 245);
            this.Controls.Add(this.btnCityDelete);
            this.Controls.Add(this.btnDeleteCityClose);
            this.Controls.Add(this.lblDeleteCityId);
            this.Controls.Add(this.lblDeleteCity);
            this.Name = "FormDeleteCity";
            this.Text = "FormDeleteCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteCity;
        public System.Windows.Forms.Label lblDeleteCityId;
        private System.Windows.Forms.Button btnDeleteCityClose;
        private System.Windows.Forms.Button btnCityDelete;
    }
}