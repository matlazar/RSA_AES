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
    public partial class Symetric : Form
    {

        AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
        public Symetric()
        {
            InitializeComponent();
            aes.GenerateIV();

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\tajni_kljuc.txt");
            byte[] plainText = Encoding.UTF8.GetBytes(txtPlain.Text.ToString());
            string kljuc = sr.ReadToEnd();
            sr.Close();
            byte[] key = Convert.FromBase64String(kljuc);
            aes.Key = key;
            ICryptoTransform transform = aes.CreateEncryptor();
            byte[] enkripcija = transform.TransformFinalBlock(plainText,0,plainText.Length);
            string str = Convert.ToBase64String(enkripcija);
            txtCrypt.Text = str;
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano_simetricno.txt";
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtCrypt.Text);
            sw.Close();
            fsOverwrite.Close();
            string path2 = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_simetricno.txt";
            FileStream fsOverwrite2 = new FileStream(path2, FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fsOverwrite2);
            sw2.WriteLine(txtPlain.Text);
            sw2.Close();
            fsOverwrite2.Close();

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano_simetricno.txt");
            string kriptiraniTekst = sr1.ReadToEnd();
            sr1.Close();
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\tajni_kljuc.txt");
            byte[] cryptText =Convert.FromBase64String(kriptiraniTekst);
            string kljuc = sr.ReadToEnd();
            sr.Close();
            byte[] key = Convert.FromBase64String(kljuc);
            aes.Key = key;
            ICryptoTransform transform = aes.CreateDecryptor();
            byte[] dekriptirano = transform.TransformFinalBlock(cryptText, 0, cryptText.Length);
            string dekriptiraniTekst = ASCIIEncoding.ASCII.GetString(dekriptirano);
            txtDecrypt.Text = dekriptiraniTekst;
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\dekriptirano_simetricno.txt";
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtDecrypt.Text);
            sw.Close();
            fsOverwrite.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano_simetricno.txt");
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_simetricno.txt");
            txtCrypt.Text = sr.ReadToEnd();
            txtPlain.Text = sr2.ReadToEnd();
            sr.Close();
            sr2.Close();
        }

        private void btnProvijeri_Click(object sender, EventArgs e)
        {
            StreamReader sr1 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\plain_simetricno.txt");
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\dekriptirano_simetricno.txt");
            if (sr1.ReadToEnd().ToString() == sr2.ReadToEnd().ToString())
            {
                txtStatus.Text = "OK";
            }
            else
            {
                txtStatus.Text = "Not OK";
            }
            sr1.Close();
            sr2.Close();
        }
    }
}
