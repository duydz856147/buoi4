using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            toaDo a = new toaDo();
            Console.WriteLine("nhap ten toa do");
            string ten = Console.ReadLine();
            a.setTen(ten);
            Console.WriteLine("nhap x");
            float x = float.Parse(Console.ReadLine());
            a.setX(x);
            Console.WriteLine("nhap y");
            float y = float.Parse(Console.ReadLine());
            a.setY(y);
            a.xuat();
            hinhTron b = new hinhTron();
            b.nhap();
            b.chuVi();
            b.dienTich();
            b.Xuat();
        }
    }
}
