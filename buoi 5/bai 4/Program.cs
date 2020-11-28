using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Hoadon
    {
        protected string hoten, makh;
        public virtual void nhap()
        {
            Console.WriteLine("nhap ma kh");makh = Console.ReadLine();
            Console.WriteLine("nhap ten khach "); hoten = Console.ReadLine();
            
        }
        public virtual void hien()
        {
            Console.WriteLine("ma khach hang\t" + makh);
            Console.WriteLine("hoten\t"+hoten);
        }
        public virtual double  giagiat()
        {
            return 0;
        }
        public virtual double giaxe()
        {
            return 0;
        }
    }
    class Dichvu:Hoadon
    {
        private double sokg;
        private double dongia;
        private double sogio;
        private double tienmotgio;
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so kg");sokg = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap tien giat"); dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so gio"); sogio = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap tien thue 1 gio"); tienmotgio = double.Parse(Console.ReadLine());
        }
        public override void hien()
        {
            base.hien();
            Console.WriteLine("dich vu giat tay");
            Console.WriteLine("so kilogam\t"+sokg);
            Console.WriteLine("tien giat\t" + giagiat());
            Console.WriteLine("dich vu thue xe");
            Console.WriteLine("so gio thue\t" + sogio);
            Console.WriteLine("tien thue xe\t" + giaxe());
        }
        public override double giagiat()
        {
            if (sokg > 10)
            {
                return (dongia * sokg) * 0.05;
            }
            else
                return dongia * sokg;
        }
        public override double giaxe()
        {
            if (sogio > 7)
            {
                return (tienmotgio * sogio) * 0.1;
            }
            else
                return tienmotgio * sogio;
        }
    }
    class Hoadonall
    {
        private int sokh;
        
        private Hoadon[] ds;
        public void nhap()
        {
            Console.WriteLine("nhap so khach hang");sokh = int.Parse(Console.ReadLine());
            ds = new Hoadon[sokh];
            for (int i = 0; i < sokh; i++)
            {
                ds[i] = new Dichvu();
                ds[i].nhap();
            }
        }
        public void hien()
        {
          
            for (int i = 0; i < sokh; i++)
            {
                ds[i].hien();
            }
        }

    }
    class MyClass
    {
        static void Main(string[] args)
        {
            Hoadonall a = new Hoadonall();
            a.nhap();Console.Clear();
            a.hien();
            Console.ReadKey();
        }
    }
}
        

