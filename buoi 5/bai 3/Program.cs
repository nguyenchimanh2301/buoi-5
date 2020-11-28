using System;

namespace bai_3
{
    class CANBO
    {
        protected double hsl, lcb;
        protected string hten, qquan;
        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten"); hten = Console.ReadLine();
            Console.WriteLine("nhap que quan"); qquan = Console.ReadLine();
            Console.WriteLine("nhap he soluong"); hsl = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap luong co ban"); lcb = double.Parse(Console.ReadLine());
        }
        public virtual void hien()
        {
            Console.WriteLine("ho ten\t\t\tquequan\t\t he so luong\t\tluong co ban\t\tLuong hang thang");
            Console.WriteLine(hten + "\t\t" + qquan + "\t\t" + hsl + "\t\t\t" + lcb + "\t\t" + Tinhluong());
        }
        public virtual double Tinhluong()
        {
            return hsl * lcb;
        }
    }
    class GIAOVIEN :CANBO
    {
        private double phucap = 1.4;
        public override void nhap()
        {
            Console.WriteLine("nhap can bo giao vien");
            base.nhap();
        }
        public override void hien()
        {
            Console.WriteLine(" tt can bo giao vien");
            base.hien();
        }
        public override double Tinhluong()
        {
            return base.Tinhluong() * phucap;    
        }
    }
    class HANHCHINH : CANBO
    {
        private double phucap = 300000;
        public override void nhap()
        {
            Console.WriteLine("nhap can bo hanh chinh");
            base.nhap();
        }
        public override void hien()
        {
            Console.WriteLine(" tt can bo hanh chinh");
            base.hien();
        }
        public override double Tinhluong()
        {
            return base.Tinhluong() + phucap;
        }
    }
    class QL
    {
        private int s;
        private CANBO[] ds;
        public void nhap()
        {
            Console.WriteLine("nhap so luong can bo");s = int.Parse(Console.ReadLine());
            ds = new CANBO[s];
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("muon nhap can bo giao vien 'G' hay can bo hanh chinh 'H'?");
                char kt = char.Parse(Console.ReadLine());
                switch(char.ToUpper(kt))
                {
                    case 'G':ds[i] = new GIAOVIEN();ds[i].nhap();break;
                    case 'H':ds[i] = new HANHCHINH();ds[i].nhap();break;
                }
            }
        }
        public void hien()
        {
            Console.WriteLine("thong tin cac can bo");
            for (int i = 0; i < s; i++)
            {
                ds[i].hien();
            }
        }
    }
    class MyClass
    {
        static void Main(string[] ars)
        {
            QL q = new QL();
            q.nhap();
            Console.Clear();
            q.hien();
            Console.ReadKey();
        }
    }
}
    
    
