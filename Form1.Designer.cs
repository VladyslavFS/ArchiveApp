namespace ArchiveApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtSource
            this.txtSource.Location = new System.Drawing.Point(120, 20);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(300, 22);
            this.txtSource.TabIndex = 0;

            // txtDestination
            this.txtDestination.Location = new System.Drawing.Point(120, 60);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(300, 22);
            this.txtDestination.TabIndex = 1;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 2;

            // lblSource
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(20, 20);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(94, 17);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source Path:";

            // lblDestination
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(20, 60);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 17);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination Path:";

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";

            // btnCompress
            this.btnCompress.Location = new System.Drawing.Point(120, 140);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(120, 30);
            this.btnCompress.TabIndex = 6;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);

            // btnDecompress
            this.btnDecompress.Location = new System.Drawing.Point(300, 140);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(120, 30);
            this.btnDecompress.TabIndex = 7;
            this.btnDecompress.Text = "Decompress";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Archive App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDecompress;
    }
}
