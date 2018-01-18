namespace Kriptografija
{
    partial class Symetric
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnProvijeri = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(30, 15);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(420, 77);
            this.txtPlain.TabIndex = 0;
            // 
            // txtCrypt
            // 
            this.txtCrypt.Location = new System.Drawing.Point(30, 107);
            this.txtCrypt.Multiline = true;
            this.txtCrypt.Name = "txtCrypt";
            this.txtCrypt.Size = new System.Drawing.Size(420, 77);
            this.txtCrypt.TabIndex = 1;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(30, 202);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(420, 77);
            this.txtDecrypt.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(456, 15);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(112, 54);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Kriptiraj";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(456, 89);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(112, 54);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Dekriptiraj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(456, 171);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(112, 32);
            this.btnUcitaj.TabIndex = 5;
            this.btnUcitaj.Text = "Učitaj datoteku";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnProvijeri
            // 
            this.btnProvijeri.Location = new System.Drawing.Point(456, 209);
            this.btnProvijeri.Name = "btnProvijeri";
            this.btnProvijeri.Size = new System.Drawing.Size(112, 32);
            this.btnProvijeri.TabIndex = 6;
            this.btnProvijeri.Text = "Provijeri";
            this.btnProvijeri.UseVisualStyleBackColor = true;
            this.btnProvijeri.Click += new System.EventHandler(this.btnProvijeri_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(456, 247);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(112, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // Symetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnProvijeri);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtCrypt);
            this.Controls.Add(this.txtPlain);
            this.Name = "Symetric";
            this.Text = "Asymetric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnProvijeri;
        private System.Windows.Forms.TextBox txtStatus;
    }
}