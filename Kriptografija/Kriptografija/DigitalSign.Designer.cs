namespace Kriptografija
{
    partial class DigitalSign
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
            this.txtUlazniTekst = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPotpisaniTekst = new System.Windows.Forms.TextBox();
            this.btnPotpisi = new System.Windows.Forms.Button();
            this.btnProvijeri = new System.Windows.Forms.Button();
            this.btnSadrzajZaProvijeru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUlazniTekst
            // 
            this.txtUlazniTekst.Location = new System.Drawing.Point(12, 12);
            this.txtUlazniTekst.Multiline = true;
            this.txtUlazniTekst.Name = "txtUlazniTekst";
            this.txtUlazniTekst.Size = new System.Drawing.Size(388, 77);
            this.txtUlazniTekst.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(113, 209);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(140, 20);
            this.txtStatus.TabIndex = 1;
            // 
            // txtPotpisaniTekst
            // 
            this.txtPotpisaniTekst.Location = new System.Drawing.Point(12, 116);
            this.txtPotpisaniTekst.Multiline = true;
            this.txtPotpisaniTekst.Name = "txtPotpisaniTekst";
            this.txtPotpisaniTekst.Size = new System.Drawing.Size(388, 77);
            this.txtPotpisaniTekst.TabIndex = 2;
            // 
            // btnPotpisi
            // 
            this.btnPotpisi.Location = new System.Drawing.Point(471, 34);
            this.btnPotpisi.Name = "btnPotpisi";
            this.btnPotpisi.Size = new System.Drawing.Size(75, 23);
            this.btnPotpisi.TabIndex = 3;
            this.btnPotpisi.Text = "Potpiši";
            this.btnPotpisi.UseVisualStyleBackColor = true;
            this.btnPotpisi.Click += new System.EventHandler(this.btnPotpisi_Click);
            // 
            // btnProvijeri
            // 
            this.btnProvijeri.Location = new System.Drawing.Point(471, 152);
            this.btnProvijeri.Name = "btnProvijeri";
            this.btnProvijeri.Size = new System.Drawing.Size(75, 23);
            this.btnProvijeri.TabIndex = 4;
            this.btnProvijeri.Text = "Provijeri";
            this.btnProvijeri.UseVisualStyleBackColor = true;
            this.btnProvijeri.Click += new System.EventHandler(this.btnProvijeri_Click);
            // 
            // btnSadrzajZaProvijeru
            // 
            this.btnSadrzajZaProvijeru.Location = new System.Drawing.Point(471, 83);
            this.btnSadrzajZaProvijeru.Name = "btnSadrzajZaProvijeru";
            this.btnSadrzajZaProvijeru.Size = new System.Drawing.Size(75, 46);
            this.btnSadrzajZaProvijeru.TabIndex = 6;
            this.btnSadrzajZaProvijeru.Text = "Učitaj datoteku";
            this.btnSadrzajZaProvijeru.UseVisualStyleBackColor = true;
            this.btnSadrzajZaProvijeru.Click += new System.EventHandler(this.btnSadrzajZaProvijeru_Click);
            // 
            // DigitalSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 272);
            this.Controls.Add(this.btnSadrzajZaProvijeru);
            this.Controls.Add(this.btnProvijeri);
            this.Controls.Add(this.btnPotpisi);
            this.Controls.Add(this.txtPotpisaniTekst);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtUlazniTekst);
            this.Name = "DigitalSign";
            this.Text = "DigitalSign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUlazniTekst;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPotpisaniTekst;
        private System.Windows.Forms.Button btnPotpisi;
        private System.Windows.Forms.Button btnProvijeri;
        private System.Windows.Forms.Button btnSadrzajZaProvijeru;
    }
}