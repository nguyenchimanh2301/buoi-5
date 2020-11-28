
using bai_1;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace bai_1
{
       class NV
    {
        public NV()
        {
            hoten = diachi = "";
            ngaysinh = 0;
        }
        public NV(string hoten,string diachi,int ngaysinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
        }
        protected string hoten, diachi;
        protected int ngaysinh;
        public virtual void nhap()
        {
            Console.WriteLine("nhap ho ten"); hoten = Console.ReadLine();
            Console.WriteLine("nhap dia chi"); diachi = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh"); ngaysinh = int.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("thong tin");
            Console.WriteLine("ho ten\t"+hoten);
            Console.WriteLine("dia chi\t"+diachi);
            Console.WriteLine("ngay sinh\t"+ngaysinh);
        }
        public virtual double tinhluong()
        {
            return 0;
        } 
    }
    class NVSX : NV
    {
        private int sosp;
        public NVSX():base()
        {
            sosp = 0;
        }
        public NVSX(string hoten, string diachi, int ngaysinh,int sosp):base( hoten,diachi,ngaysinh)
        {
            this.sosp = sosp;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so sp"); sosp = int.Parse(Console.ReadLine());
        }
        public override  void xuat()
        {
            Console.WriteLine("NVSX");
            base.xuat();
            Console.WriteLine("so sp\t"+sosp);
            Console.WriteLine("luong\t"+tinhluong());
        }
        public override double tinhluong()
        {
            return sosp * 20000;
        }
    }
    class NVCN:NV
    {
        private int sonc;
        public NVCN():base()
        {
            sonc = 0;
        }
        public NVCN(string hoten, string diachi, int ngaysinh,int sonc):base(hoten, diachi, ngaysinh)
        {
            this.sonc = sonc;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so ngay cong"); sonc = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("NVCN");
            base.xuat();
            Console.WriteLine("so ngay cong\t" + sonc);
            Console.WriteLine("luong\t" + tinhluong());
        }
        public override double tinhluong()
        {
            return sonc * 50000;
        }
    }
    class NVQL:NV
    {
        private double hsl, lcb;
        public NVQL():base()
        {
            hsl = lcb = 0;
        }
        public NVQL(string hoten, string diachi,int ngaysinh,double hsl,double lcb ):base(hoten, diachi, ngaysinh)
        {
            this.hsl = hsl;
            this.lcb = lcb;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap he so luong"); hsl = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap luong co ban");lcb = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.WriteLine("NVQL");
            base.xuat();
            Console.WriteLine("he so luong\t" + hsl);
            Console.WriteLine("luong co ban\t"+lcb);
            Console.WriteLine("luong\t" + tinhluong());
        }
        public override double tinhluong()
        {
            return hsl * lcb;
        }
    }
   
    }
    class DSNV
    {
        private int sonv;
        private NV [] ds;
       
          public void nhap()
        {
            Console.WriteLine("nhap so luong nv"); sonv = int.Parse(Console.ReadLine());
            ds = new NV[sonv];
           
            for (int i = 0; i < sonv; i++)
            {
            Console.WriteLine("nhap NVXS 'A' hay NVCB 'B' hay NVQL 'C'");
            char kt = char.Parse(Console.ReadLine());
            switch (char.ToUpper(kt))
            {
                case 'A': ds[i] = new NVSX();ds[i].nhap();break;
                case 'B': ds[i] = new NVCN();ds[i].nhap();break;
                case 'C': ds[i] = new NVQL();ds[i].nhap();break;
            }
            }
        }
        public void hien()
        {
            for (int i = 0; i < sonv; i++)
            {
            ds[i].xuat();
            Console.WriteLine();
            }
        }
    }

class acbc
{
    static void Main(string[] args)
    {
        DSNV q = new DSNV();
        q.nhap(); q.hien();
        Console.ReadKey();
    }
}

