namespace Kriptografija
{
    partial class FrmKeys
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
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.btnPublicKey = new System.Windows.Forms.Button();
            this.btnSecretKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(25, 51);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(170, 23);
            this.btnPrivateKey.TabIndex = 0;
            this.btnPrivateKey.Text = "Privatni ključ";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // btnPublicKey
            // 
            this.btnPublicKey.Location = new System.Drawing.Point(25, 80);
            this.btnPublicKey.Name = "btnPublicKey";
            this.btnPublicKey.Size = new System.Drawing.Size(170, 23);
            this.btnPublicKey.TabIndex = 1;
            this.btnPublicKey.Text = "Javni ključ";
            this.btnPublicKey.UseVisualStyleBackColor = true;
            this.btnPublicKey.Click += new System.EventHandler(this.btnPublicKey_Click);
            // 
            // btnSecretKey
            // 
            this.btnSecretKey.Location = new System.Drawing.Point(25, 109);
            this.btnSecretKey.Name = "btnSecretKey";
            this.btnSecretKey.Size = new System.Drawing.Size(170, 23);
            this.btnSecretKey.TabIndex = 2;
            this.btnSecretKey.Text = "Tajni ključ";
            this.btnSecretKey.UseVisualStyleBackColor = true;
            this.btnSecretKey.Click += new System.EventHandler(this.btnSecretKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(201, 51);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(385, 290);
            this.txtKey.TabIndex = 3;
            // 
            // FrmKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnSecretKey);
            this.Controls.Add(this.btnPublicKey);
            this.Controls.Add(this.btnPrivateKey);
            this.Name = "FrmKeys";
            this.Text = "FrmKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.Button btnPublicKey;
        private System.Windows.Forms.Button btnSecretKey;
        private System.Windows.Forms.TextBox txtKey;
    }
}