using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    public class toaDo
    {
        private string ten;
        private float x;
        private float y;

        public toaDo()
        {
            x = 0;
            y = 0;
            ten = "";
        }

        public toaDo(float x, float y, string ten)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;

        }
        public void setTen(string ten)
        {
            this.ten = ten;
        }
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }
        public string getTen()
        {
            return ten;
        }
        public void xuat()
        {
            Console.WriteLine("hinh tron co tam {0} ({1}, {2})", ten, x, y);
        }

    }
}
