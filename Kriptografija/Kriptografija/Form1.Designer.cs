namespace Kriptografija
{
    partial class Form1
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
            this.btnKeys = new System.Windows.Forms.Button();
            this.btnSymetric = new System.Windows.Forms.Button();
            this.btnAsymetric = new System.Windows.Forms.Button();
            this.btnDigitalSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeys
            // 
            this.btnKeys.Location = new System.Drawing.Point(72, 27);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(123, 30);
            this.btnKeys.TabIndex = 0;
            this.btnKeys.Text = "Ključevi";
            this.btnKeys.UseVisualStyleBackColor = true;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // btnSymetric
            // 
            this.btnSymetric.Location = new System.Drawing.Point(72, 85);
            this.btnSymetric.Name = "btnSymetric";
            this.btnSymetric.Size = new System.Drawing.Size(123, 30);
            this.btnSymetric.TabIndex = 1;
            this.btnSymetric.Text = "Asimetrično kriptiranje";
            this.btnSymetric.UseVisualStyleBackColor = true;
            this.btnSymetric.Click += new System.EventHandler(this.btnSymetric_Click);
            // 
            // btnAsymetric
            // 
            this.btnAsymetric.Location = new System.Drawing.Point(72, 132);
            this.btnAsymetric.Name = "btnAsymetric";
            this.btnAsymetric.Size = new System.Drawing.Size(123, 30);
            this.btnAsymetric.TabIndex = 2;
            this.btnAsymetric.Text = "Simetrično kriptiranje";
            this.btnAsymetric.UseVisualStyleBackColor = true;
            this.btnAsymetric.Click += new System.EventHandler(this.btnAsymetric_Click);
            // 
            // btnDigitalSign
            // 
            this.btnDigitalSign.Location = new System.Drawing.Point(72, 187);
            this.btnDigitalSign.Name = "btnDigitalSign";
            this.btnDigitalSign.Size = new System.Drawing.Size(123, 30);
            this.btnDigitalSign.TabIndex = 3;
            this.btnDigitalSign.Text = "Digitalni potpis";
            this.btnDigitalSign.UseVisualStyleBackColor = true;
            this.btnDigitalSign.Click += new System.EventHandler(this.btnDigitalSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDigitalSign);
            this.Controls.Add(this.btnAsymetric);
            this.Controls.Add(this.btnSymetric);
            this.Controls.Add(this.btnKeys);
            this.Name = "Form1";
            this.Text = "Opcije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeys;
        private System.Windows.Forms.Button btnSymetric;
        private System.Windows.Forms.Button btnAsymetric;
        private System.Windows.Forms.Button btnDigitalSign;
    }
}

