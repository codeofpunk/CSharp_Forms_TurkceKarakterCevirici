using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkceKarakterCevirici
{
    public partial class Form1 : Form
    {
        public string yazi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazi = richTextBox1.Text;

            listBox1.Items.Add("* " + EngCevir(yazi));


        }

        public string EngCevir(string yazi)
        {
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("Ç", "C");
            yazi = yazi.Replace("ç", "c");
            return yazi;
        }
    }
}
