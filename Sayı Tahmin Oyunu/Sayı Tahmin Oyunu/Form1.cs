using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            Random rdr = new Random();
            int sayi;
            sayi = rdr.Next(1, 10);
            label4.Text = sayi.ToString();
            label4.Visible = false;
        }
        int can = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            int tahmin = 0;

            tahmin = Convert.ToInt32(textBox1.Text);

            if (label4.Text == tahmin.ToString())
            {
                int cevap = Convert.ToInt32((textBox1.Text).ToString());
                MessageBox.Show("Tahmininiz Doğru"+ cevap.ToString());

                label4.Visible = true;
            }
            else
            {
                can--;
                label2.Text = can.ToString();

            }
            if (can == 0)
            {
                label4.Visible = true;
                int cevap = Convert.ToInt32((label4.Text).ToString());
                MessageBox.Show("Oyun bitti.Cevap :" +cevap.ToString());
            }

        }
    }
}
