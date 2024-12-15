using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Klavyeden tcno(maskedbox),tel(maskedbox),adı(textbox),soyadı(textbox),şehride(textbox)
        //doğumtarihi(datetimepicker) girilen kişinin botuona basıldığı zaman bilgilerini listbox'a aktaran programı yazınız.
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text +" "+textBox2.Text +" "+maskedTextBox1.Text+" "+maskedTextBox2.Text+" "+dateTimePicker1.Text+" "+textBox3.Text+" ");
        }
    }
}
