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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int sayi = 0;

        private void BtnKac_MouseMove(object sender, MouseEventArgs e)
        {
            BtnKac.Location = new Point(0, 0);
            Random rnd = new Random();
            int x = rnd.Next(this.Width - BtnKac.Width);
            int y = rnd.Next(this.Height - BtnKac.Height);
            BtnKac.Location = new Point(x, y);
            sayi++;
            BtnKac.Text = sayi.ToString();


        }
        byte time = 10;

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            this.Text = time.ToString();
            if (time == 0)
            {
                timer.Stop();
                MessageBox.Show($"Puanınız {sayi}","game over");
                this.Close();
            }



        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer.Start();
            this.Text = time.ToString();
        }
    }
}
