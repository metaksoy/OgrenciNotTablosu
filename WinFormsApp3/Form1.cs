namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number = 0;
        public void liste()
        {
            insan who = new insan();
            switch (number)
            {
                case 1:
                    who.isim = "Ahmet";
                    who.soyisim = "Kabayel";
                    who.tc = 2002523564;
                    who.sýnýfno = "4/A";
                    who.ders = "Matematik";
                    who.dersnotu = 45;
                    who.dersgecti = "Geçti";
                    who.derskaldi = "Kaldý";



                    string marka = who.markagetir();
                    label23.Text = who.isim;
                    label22.Text = who.soyisim;
                    label21.Text = who.tc.ToString();
                    label20.Text = who.sýnýfno;
                    label19.Text = who.ders;
                    label12.Text = who.dersnotu.ToString();
                    if (who.dersnotu > 55)
                    {
                        label1.Text = who.dersgecti;
                    }
                    else
                    {
                        label1.Text = who.derskaldi;
                    }
                    break;
                    
                    //Öðrenci 2

                    case 2:
                   
                    who.isim = "mehmet";
                    who.soyisim = "aksoy";
                    who.tc = 1962523564;
                    who.sýnýfno = "4/A";
                    who.ders = "Matematik";
                    who.dersnotu = 90;
                    who.dersgecti = "Geçti";
                    who.derskaldi = "Kaldý";



                    string marka1 = who.markagetir();
                    label23.Text = who.isim;
                    label22.Text = who.soyisim;
                    label21.Text = who.tc.ToString();
                    label20.Text = who.sýnýfno;
                    label19.Text = who.ders;
                    label12.Text = who.dersnotu.ToString();
                    if (who.dersnotu > 55)
                    {
                        label1.Text = who.dersgecti;
                    }
                    else
                    {
                        label1.Text = who.derskaldi;
                    }
                    break;

                    case 3:
                    
                    who.isim = "Ayþe";
                    who.soyisim = "aslan";
                    who.tc = 1962523564;
                    who.sýnýfno = "4/A";
                    who.ders = "Matematik";
                    who.dersnotu = 20;
                    who.dersgecti = "Geçti";
                    who.derskaldi = "Kaldý";



                    string marka2 = who.markagetir();
                    label23.Text = who.isim;
                    label22.Text = who.soyisim;
                    label21.Text = who.tc.ToString();
                    label20.Text = who.sýnýfno;
                    label19.Text = who.ders;
                    label12.Text = who.dersnotu.ToString();
                    if (who.dersnotu > 55)
                    {
                        label1.Text = who.dersgecti;
                    }
                    else
                    {
                        label1.Text = who.derskaldi;
                    }
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            number++;
            liste();
            if (number == 3)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (number == 1)
            {
                button2.Enabled = true;
            }

            //who.isim = "Ahmet";
            //who.soyisim = "Kabayel";
            //who.tc = 2002523564;
            //who.sýnýfno = "4/A";
            //who.ders = "Matematik";
            //who.dersnotu = 45;
            //who.dersgecti = "Geçti";
            //who.derskaldi = "Kaldý";



            //string marka = who.markagetir();
            //label23.Text = who.isim;
            //label22.Text = who.soyisim;
            //label21.Text = who.tc.ToString();
            //label20.Text = who.sýnýfno;
            //label19.Text = who.ders;
            //label12.Text = who.dersnotu.ToString();
            //if (who.dersnotu > 55)
            //{
            //    label1.Text = who.dersgecti;
            //}
            //else
            //{
            //    label1.Text = who.derskaldi;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(number == 2) {
                button2.Enabled = false;
                button1.Enabled = true;
            }

            number--;
            liste();


            //insan who = new insan();
            //who.isim = "mehmet";
            //who.soyisim = "aksoy";
            //who.tc = 1962523564;
            //who.sýnýfno = "4/A";
            //who.ders = "Matematik";
            //who.dersnotu = 90;
            //who.dersgecti = "Geçti";
            //who.derskaldi = "Kaldý";



            //string marka = who.markagetir();
            //label23.Text = who.isim;
            //label22.Text = who.soyisim;
            //label21.Text = who.tc.ToString();
            //label20.Text = who.sýnýfno;
            //label19.Text = who.ders;
            //label12.Text = who.dersnotu.ToString();
            //if (who.dersnotu > 55)
            //{
            //    label1.Text = who.dersgecti;
            //}
            //else
            //{
            //    label1.Text = who.derskaldi;
            //}



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}