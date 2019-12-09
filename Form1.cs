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

namespace Decode
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("PrivateKey.xml"))
            {
                using (StreamReader streamReader = new StreamReader("PrivateKey.xml")) // 读取运行目录下的PublicKey.xml
                {
                    rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(streamReader.ReadToEnd()); // 将公匙载入进RSA实例中
                }
            }
            else
            {
                MessageBox.Show("软件根目录缺少公钥文件：PrivateKey.xml");
                Application.Exit();
            }
        }

        string RSADecrypt(string content)
        {
            string decryptedContent = string.Empty;
            byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(content), false);
            decryptedContent = Encoding.GetEncoding("utf-8").GetString(decryptedData);
            return decryptedContent;
        }
        private void buttonDe_Click(object sender, EventArgs e)
        {
            textBoxString.Text = RSADecrypt(textBoxEnString.Text);
        }
    }
}
