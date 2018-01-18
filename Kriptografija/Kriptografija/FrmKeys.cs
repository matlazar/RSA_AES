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
using System.Xml.Serialization;

namespace Kriptografija
{
    public partial class FrmKeys : Form
    {
        public RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        public FrmKeys()
        {
            InitializeComponent();
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            string str = rsa.ToXmlString(true).ToString();         
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\privatni_kljuc.txt";
            txtKey.Text = str;
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtKey.Text);
            sw.Close();
        }

        private void btnPublicKey_Click(object sender, EventArgs e)
        {
            string str = rsa.ToXmlString(false).ToString();
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\javni_kljuc.txt";
            txtKey.Text = str;
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(str);
            sw.Close();
        }

        private void btnSecretKey_Click(object sender, EventArgs e)
        {
            string path = @"D:\Fakultet informatike i organizacije\I_semestar_diplomski\Operacijski sustavi 2\Projekt-kriptografija\Kriptografija\tajni_kljuc.txt";
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.GenerateKey();
            aes.GenerateIV();
            aes.Padding = PaddingMode.None;
            aes.BlockSize = 128;
            txtKey.Text = Convert.ToBase64String(aes.Key);
            FileStream fsOverwrite = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fsOverwrite);
            sw.WriteLine(txtKey.Text);
            sw.Close();
        }
    }
}
