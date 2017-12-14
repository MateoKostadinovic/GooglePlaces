namespace GooglePlaces
{
    partial class FormDeleteType
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
            this.lblDeleteTypeId = new System.Windows.Forms.Label();
            this.btnDeleteTypeClose = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.lblDeleteType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteTypeId
            // 
            this.lblDeleteTypeId.AutoSize = true;
            this.lblDeleteTypeId.Location = new System.Drawing.Point(37, 97);
            this.lblDeleteTypeId.Name = "lblDeleteTypeId";
            this.lblDeleteTypeId.Size = new System.Drawing.Size(40, 13);
            this.lblDeleteTypeId.TabIndex = 0;
            this.lblDeleteTypeId.Text = "TypeId";
            this.lblDeleteTypeId.Visible = false;
            // 
            // btnDeleteTypeClose
            // 
            this.btnDeleteTypeClose.Location = new System.Drawing.Point(12, 154);
            this.btnDeleteTypeClose.Name = "btnDeleteTypeClose";
            this.btnDeleteTypeClose.Size = new System.Drawing.Size(159, 77);
            this.btnDeleteTypeClose.TabIndex = 1;
            this.btnDeleteTypeClose.Text = "Close";
            this.btnDeleteTypeClose.UseVisualStyleBackColor = true;
            this.btnDeleteTypeClose.Click += new System.EventHandler(this.btnDeleteTypeClose_Click);
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.Location = new System.Drawing.Point(192, 154);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(159, 77);
            this.btnTypeDelete.TabIndex = 2;
            this.btnTypeDelete.Text = "Delete";
            this.btnTypeDelete.UseVisualStyleBackColor = true;
            this.btnTypeDelete.Click += new System.EventHandler(this.btnTypeDelete_Click);
            // 
            // lblDeleteType
            // 
            this.lblDeleteType.AutoSize = true;
            this.lblDeleteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteType.Location = new System.Drawing.Point(118, 40);
            this.lblDeleteType.Name = "lblDeleteType";
            this.lblDeleteType.Size = new System.Drawing.Size(133, 25);
            this.lblDeleteType.TabIndex = 3;
            this.lblDeleteType.Text = "Delete type?";
            // 
            // FormDeleteType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 243);
            this.Controls.Add(this.lblDeleteType);
            this.Controls.Add(this.btnTypeDelete);
            this.Controls.Add(this.btnDeleteTypeClose);
            this.Controls.Add(this.lblDeleteTypeId);
            this.Name = "FormDeleteType";
            this.Text = "Obriši tip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDeleteTypeId;
        private System.Windows.Forms.Button btnDeleteTypeClose;
        private System.Windows.Forms.Button btnTypeDelete;
        private System.Windows.Forms.Label lblDeleteType;
    }
}