namespace Kriptografija
{
    partial class Asymetric
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
            this.btnCrypt = new System.Windows.Forms.Button();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(173, 71);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(126, 23);
            this.btnCrypt.TabIndex = 0;
            this.btnCrypt.Text = "Kriptiraj";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(12, 13);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(429, 52);
            this.txtPlain.TabIndex = 1;
            // 
            // txtCrypt
            // 
            this.txtCrypt.Location = new System.Drawing.Point(12, 104);
            this.txtCrypt.Multiline = true;
            this.txtCrypt.Name = "txtCrypt";
            this.txtCrypt.Size = new System.Drawing.Size(429, 52);
            this.txtCrypt.TabIndex = 2;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(12, 197);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(429, 52);
            this.txtDecrypt.TabIndex = 3;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(173, 168);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(126, 23);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Dekriptiraj";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Učitaj datoteke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(173, 298);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(144, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Provijeri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Asymetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtCrypt);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.btnCrypt);
            this.Name = "Asymetric";
            this.Text = "Symetric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button button2;
    }
}