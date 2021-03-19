using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{
    class HD
    {
        public String mahd { get; set; }
        public String makh { get; set; }
        public String manv { get; set; }
        public String ngaylap { get; set; }
        public String tongtien { get; set; }

        public HD()
        {

        }
        public HD(String mhd, String mkh, String mnv, String ngay, String tt)
        {
            mahd = mhd;
            makh = mkh;
            manv = mnv;
            ngaylap = ngay;
            tongtien = tt;
        }
    }
}
