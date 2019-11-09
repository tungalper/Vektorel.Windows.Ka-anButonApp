using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.KaçanButonApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi1.Text = rnd.Next(100).ToString();
            sayi2.Text = rnd.Next(100).ToString();
            sayi3.Text = rnd.Next(100).ToString();

        }

        private void Sayi1_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            toplam += int.Parse(buton.Text);
            buton.Enabled = false;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toplam.ToString());
        }

       
    }
}
