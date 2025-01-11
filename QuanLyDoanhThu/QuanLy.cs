using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoanhThu
{
    class QuanLy
    {
        private string _tenCLB;
        private string _tenNuoc;
        private int _SLVe;
        private double _GiaVe;

        public QuanLy()
        {
        }

        public QuanLy(string tenCLB, string tenNuoc, int sLVe, double giaVe)
        {
            _tenCLB = tenCLB;
            _tenNuoc = tenNuoc;
            _SLVe = sLVe;
            _GiaVe = giaVe;
        }

        public string TenCLB { get => _tenCLB; set => _tenCLB = value; }
        public string TenNuoc { get => _tenNuoc; set => _tenNuoc = value; }
        public int SLVe { get => _SLVe; set => _SLVe = value; }
        public double GiaVe { get => _GiaVe; set => _GiaVe = value; }

        public double DoanhTHU()
        {
            return SLVe * GiaVe;
        }
    }
}
