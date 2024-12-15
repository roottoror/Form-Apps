using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dostum");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text="Ilhan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Haydar";
            label7.Text = "Bulut";
            label8.Text = "Bilgisayar Mühendisi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Not:Nereye yazdıracaksam orası sol tarafa yazılır.
            //Not:Ne yazdıracaksan ya da nereden  o da sağ tarafa yazdırılır
            //textBox1.Text = "Merhaba";
            label9.Text = textBox1.Text;

        }
    }
}
