using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaEncrip
{
    public partial class Form1 : Form
    {
        MD5 mD5 = MD5.Create();
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] b = Encoding.ASCII.GetBytes(textBox1.Text);
            byte[] hash = mD5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
            textBox2.Text = sb.ToString();
        }
    }
}
