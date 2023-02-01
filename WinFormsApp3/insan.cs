using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class insan
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int tc { get; set; }

        public string sınıfno { get; set; }
        public string ders { get; set; }
        public int dersnotu { get; set; }

        public string dersgecti { get; set; }
        public string derskaldi { get; set; }

        public string markagetir()
        { return isim; }
    }
}
