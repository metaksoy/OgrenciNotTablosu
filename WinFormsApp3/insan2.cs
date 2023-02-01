using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class insan2 : Form
    {
        public insan2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 birinciform = new Form1();
            birinciform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insan who = new insan();
            who.isim = "Mehmet";
            who.soyisim = "aksoy";
            who.tc = 1962523564;
            who.sınıfno = "4/A";
            who.ders = "Matematik";
            who.dersnotu = 85;



            string marka = who.markagetir();
            label10.Text = who.isim;
            label9.Text = who.soyisim;
            label8.Text = who.tc.ToString();
            label7.Text = who.sınıfno;
            label6.Text = who.ders;
            label12.Text = who.dersnotu.ToString();
        }
    }
}
