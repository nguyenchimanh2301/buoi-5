using System;

namespace bs2
{
    public class person
    {
        protected string hoten, quequan;
        protected int NTNS;
        public person()
        {
            hoten = quequan = "";
            NTNS = 0;
        }
        public person(string hoten,string quequan,int NTNS)
        {
            this.hoten = hoten;
            this.quequan = quequan;
            this.NTNS = NTNS;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten:");hoten = Console.ReadLine();
            Console.Write("Nhap que quan:");quequan = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh:");NTNS = int.Parse(Console.ReadLine());
        }
        public virtual void Hien()
        {
            Console.WriteLine("Thong tin");
            Console.WriteLine("Ho ten:{0}\t Que quan:{1}\t Ngay thang nam sinh:{2}", hoten, quequan, NTNS);
        }
    }
    public class SINHVIEN:person
    {
        private string MSV,Lop;
        public SINHVIEN()
        {
            MSV = Lop = "";
        }
        public SINHVIEN(string hoten,string quequan,int NTNS,string MSV,string Lop):base(hoten,quequan,NTNS)
        {
            this.MSV = MSV;
            this.Lop = Lop;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma sinh vien:");MSV = Console.ReadLine();
            Console.Write("Nhap lop:");Lop = Console.ReadLine();
        }
        public new void Hien()
        {
            base.Hien();
            Console.WriteLine("Thong tin Sinh vien");
            Console.Write("Ma sinh vien:{0}\t Lop:{1}", MSV, Lop);
        }
    }
    class test
    {
       
        static void Main(string[] args)
        {
            SINHVIEN a = new SINHVIEN();
            a.Nhap();a.Hien();
            Console.ReadKey();
        }
    }
}
