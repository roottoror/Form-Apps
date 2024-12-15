using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Butona bastığın zaman kişinin adını soyadını,mesleğini,yaşını ve maaşını bilgilerini textboxtan alıp yan yana
            //yazdıran kodu listboxtan gösteriniz.
            listBox1.Items.Add((textBox1.Text + " " + " " + textBox2.Text + " " + " " + textBox3.Text + " " + " " + textBox4.Text + " " + " " + textBox5.Text));
        }
    }
}
