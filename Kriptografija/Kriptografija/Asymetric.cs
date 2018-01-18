using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija
{
    public partial class Asymetric : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        public Asymetric()
        {
            InitializeComponent();

        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            byte[] plainText = Encoding.UTF8.GetBytes(txtPlain.Text.ToString());
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano.txt";
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\javni_kljuc.txt");
            string path2 = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_text.txt";
            string kljuc = sr.ReadToEnd();
            sr.Close();
            rsa.FromXmlString(kljuc.ToString());
            byte [] kriptirano = rsa.Encrypt(plainText, true);
            txtCrypt.Text = Convert.ToBase64String(kriptirano);
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtCrypt.Text);
            sw.Close();
            fsOverwrite.Close();
            FileStream fsOverwrite2 = new FileStream(path2, FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fsOverwrite2);
            sw2.WriteLine(txtPlain.Text);
            sw2.Close();
            fsOverwrite2.Close();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            StreamReader sr1 =new StreamReader( @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano.txt");
            string kriptiraniTekst = sr1.ReadToEnd();
            sr1.Close();
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\dekriptirano.txt";
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\privatni_kljuc.txt");
            byte[] enkripcija = Convert.FromBase64String(kriptiraniTekst); 
            string kljuc = sr.ReadToEnd();
            sr.Close();
            rsa.FromXmlString(kljuc.ToString());
            byte[] dekriptirano = rsa.Decrypt(enkripcija, true);
            string dekriptiraniPodaci = Encoding.UTF8.GetString(dekriptirano);
            txtDecrypt.Text = dekriptiraniPodaci.ToString();
            FileStream fsOverWrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverWrite);
            sw.WriteLine(txtDecrypt.Text);
            sw.Close();
            fsOverWrite.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano.txt");
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_text.txt");
            txtCrypt.Text = sr.ReadToEnd();
            txtPlain.Text = sr2.ReadToEnd();
            sr.Close();
            sr2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_text.txt");
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\dekriptirano.txt");
            if(sr1.ReadToEnd().ToString() == sr2.ReadToEnd().ToString())
            {
                txtStatus.Text = "OK";
            }else
            {
                txtStatus.Text = "Not OK";
            }
            sr1.Close();
            sr2.Close();
        }
    }
}
