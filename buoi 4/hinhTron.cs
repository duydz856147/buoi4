using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    public class hinhTron
    {
        private string tenHinhTron;
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public void nhap()
        {
            Console.WriteLine("nhap ban kinh");
            double banKinh = double.Parse(Console.ReadLine());
        }
        public double chuVi()
        {
            return 2 * 3.14 * banKinh;
        }
        public double dienTich()
        {
            return Math.PI * Math.Pow(banKinh, 2);
        }
        public void Xuat()
        {
            Console.WriteLine("voi ban kinh {0} co dien tich va chu vi lan luot la {1} va {2}", banKinh, chuVi(), dienTich());
        }
    }
}
