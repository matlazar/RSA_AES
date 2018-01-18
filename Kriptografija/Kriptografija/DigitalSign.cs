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
    public partial class DigitalSign : Form
    {
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public DigitalSign()
        {
            InitializeComponent();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\kriptirano.txt");
            string kriptiranoZaPotpis = sr.ReadToEnd();
            sr.Close();
            txtUlazniTekst.Text = kriptiranoZaPotpis;
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\privatni_kljuc.txt");
            string stringKljuc = sr2.ReadToEnd();
            sr2.Close();
            RSA.FromXmlString(stringKljuc.ToString());
            byte [] HashValue = Encoding.UTF8.GetBytes(kriptiranoZaPotpis);
            SHA256 sha256 = new SHA256Managed();
            HashValue = sha256.ComputeHash(HashValue);
            byte[] SignedHashValue;
            RSAPKCS1SignatureFormatter RSAForamatter = new RSAPKCS1SignatureFormatter(RSA);
            RSAForamatter.SetHashAlgorithm("SHA256");
            SignedHashValue = RSAForamatter.CreateSignature(HashValue);
            txtPotpisaniTekst.Text = Convert.ToBase64String(SignedHashValue);
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\potpisano.txt";
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtPotpisaniTekst.Text);
            sw.Close();
            fsOverwrite.Close();
            string path2 = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\prije_potpisa.txt";
            FileStream fsOverwrite2 = new FileStream(path2, FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fsOverwrite2);
            string spremiHash = Convert.ToBase64String(HashValue);
            sw2.WriteLine(spremiHash);
            sw2.Close();
            fsOverwrite2.Close();

        }

        private void btnSadrzajZaProvijeru_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\prije_potpisa.txt");
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\potpisano.txt");
            //txtUlazniTekst.Text = sr.ReadToEnd();
            txtPotpisaniTekst.Text = sr2.ReadToEnd();
            //sr.Close();
            sr2.Close();
        }

        private void btnProvijeri_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\privatni_kljuc.txt");
            string stringKljuc = sr.ReadToEnd();
            sr.Close();
            RSA.FromXmlString(stringKljuc.ToString());
            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(RSA);
            StreamReader sr1 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\prije_potpisa.txt");
            string prijePotpisa = sr1.ReadToEnd();
            sr1.Close();
            byte[] HashPrijePotpisa = Convert.FromBase64String(prijePotpisa);
            StreamReader sr2 = new StreamReader(@"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\potpisano.txt");
            string potpisaniHash = sr2.ReadToEnd();
            sr2.Close();
            byte[] potpis = Convert.FromBase64String(potpisaniHash);
            RSADeformatter.SetHashAlgorithm("SHA256");
            if (RSADeformatter.VerifySignature(HashPrijePotpisa,potpis))
            {
                txtStatus.Text = "Dobar potpis"; 
            }
            else
            {
                txtStatus.Text = "Loš potpis";
            }

        }
    }
}
