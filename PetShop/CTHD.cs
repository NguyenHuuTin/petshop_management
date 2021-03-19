using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class CTHD
    {
        public String Tendv { get; set; }
        public String Soluong { get; set; }
        public String DonGia { get; set; }
        public String TongTien { get; set; }

        public CTHD()
        {

        }
        public CTHD(String name, String sl, String gia, String tt)
        {
            Tendv = name;
            Soluong = sl;
            DonGia = gia;
            TongTien = tt;
        }
    }
}
