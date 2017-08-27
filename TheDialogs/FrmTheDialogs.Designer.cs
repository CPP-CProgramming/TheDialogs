namespace TheDialogs
{
    partial class FrmTheDialogs
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
            this.btnDialogs = new System.Windows.Forms.Button();
            this.btnCustm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialogs
            // 
            this.btnDialogs.Location = new System.Drawing.Point(302, 67);
            this.btnDialogs.Name = "btnDialogs";
            this.btnDialogs.Size = new System.Drawing.Size(163, 63);
            this.btnDialogs.TabIndex = 0;
            this.btnDialogs.Text = "Dialogs";
            this.btnDialogs.UseVisualStyleBackColor = true;
            this.btnDialogs.Click += new System.EventHandler(this.btnDialogs_Click);
            // 
            // btnCustm
            // 
            this.btnCustm.Location = new System.Drawing.Point(302, 183);
            this.btnCustm.Name = "btnCustm";
            this.btnCustm.Size = new System.Drawing.Size(163, 53);
            this.btnCustm.TabIndex = 1;
            this.btnCustm.Text = "Custom Dialog";
            this.btnCustm.UseVisualStyleBackColor = true;
            this.btnCustm.Click += new System.EventHandler(this.btnCustm_Click);
            // 
            // FrmTheDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 367);
            this.Controls.Add(this.btnCustm);
            this.Controls.Add(this.btnDialogs);
            this.Name = "FrmTheDialogs";
            this.Text = "Dialog Demos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialogs;
        private System.Windows.Forms.Button btnCustm;
    }
}

