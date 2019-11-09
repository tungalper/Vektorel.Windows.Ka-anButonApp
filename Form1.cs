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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Size = new Size(100, 20);
            btn.Text = "YENI BUTTON";
            btn.Click += Button1_Click;
            this.Controls.Add(btn);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            MessageBox.Show(buton.Text + "Cliked");
        }


       
    }
}
