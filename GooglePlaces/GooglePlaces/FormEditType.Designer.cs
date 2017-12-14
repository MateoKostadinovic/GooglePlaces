namespace GooglePlaces
{
    partial class FormEditType
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
            this.lblEditTypeName = new System.Windows.Forms.Label();
            this.lblEditTypeValue = new System.Windows.Forms.Label();
            this.inptEditTypeName = new System.Windows.Forms.TextBox();
            this.inptEditTypeValue = new System.Windows.Forms.TextBox();
            this.btnEditType = new System.Windows.Forms.Button();
            this.lblTypeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditTypeName
            // 
            this.lblEditTypeName.AutoSize = true;
            this.lblEditTypeName.Location = new System.Drawing.Point(30, 99);
            this.lblEditTypeName.Name = "lblEditTypeName";
            this.lblEditTypeName.Size = new System.Drawing.Size(35, 13);
            this.lblEditTypeName.TabIndex = 0;
            this.lblEditTypeName.Text = "Name";
            // 
            // lblEditTypeValue
            // 
            this.lblEditTypeValue.AutoSize = true;
            this.lblEditTypeValue.Location = new System.Drawing.Point(30, 158);
            this.lblEditTypeValue.Name = "lblEditTypeValue";
            this.lblEditTypeValue.Size = new System.Drawing.Size(34, 13);
            this.lblEditTypeValue.TabIndex = 1;
            this.lblEditTypeValue.Text = "Value";
            // 
            // inptEditTypeName
            // 
            this.inptEditTypeName.Location = new System.Drawing.Point(134, 99);
            this.inptEditTypeName.Name = "inptEditTypeName";
            this.inptEditTypeName.Size = new System.Drawing.Size(156, 20);
            this.inptEditTypeName.TabIndex = 2;
            // 
            // inptEditTypeValue
            // 
            this.inptEditTypeValue.Location = new System.Drawing.Point(134, 158);
            this.inptEditTypeValue.Name = "inptEditTypeValue";
            this.inptEditTypeValue.Size = new System.Drawing.Size(156, 20);
            this.inptEditTypeValue.TabIndex = 3;
            // 
            // btnEditType
            // 
            this.btnEditType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditType.Location = new System.Drawing.Point(134, 209);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(156, 50);
            this.btnEditType.TabIndex = 4;
            this.btnEditType.Text = "Save";
            this.btnEditType.UseVisualStyleBackColor = false;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Location = new System.Drawing.Point(30, 28);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(40, 13);
            this.lblTypeId.TabIndex = 7;
            this.lblTypeId.Text = "TypeId";
            this.lblTypeId.Visible = false;
            // 
            // FormEditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 271);
            this.Controls.Add(this.lblTypeId);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.inptEditTypeValue);
            this.Controls.Add(this.inptEditTypeName);
            this.Controls.Add(this.lblEditTypeValue);
            this.Controls.Add(this.lblEditTypeName);
            this.Name = "FormEditType";
            this.Text = "Uređivanje tipa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditTypeName;
        private System.Windows.Forms.Label lblEditTypeValue;
        public System.Windows.Forms.TextBox inptEditTypeName;
        public System.Windows.Forms.TextBox inptEditTypeValue;
        private System.Windows.Forms.Button btnEditType;
        public System.Windows.Forms.Label lblTypeId;
    }
}