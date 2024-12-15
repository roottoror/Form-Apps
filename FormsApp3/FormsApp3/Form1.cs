using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");//Combobox'a öğe ekle.
            comboBox1.Items.Add("Izmir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Textboxa girilmiş olan metni comboboxa ekleyen kodu yazınız:
            /*kENDİ YAZDIĞIM KOD:
            string eklenen = textBox1.Text;
            comboBox1.Items.Add(eklenen);
            */
            //Combobox'a textboxtan gelen metin öğesini ekle:
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pilot");
            listBox1.Items.Add("Kasiyer");
            listBox1.Items.Add("Muhasebeci");
            listBox1.Items.Add("Antröner"); 



        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }
    }

}
