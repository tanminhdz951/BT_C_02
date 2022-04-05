using System;

namespace ConsoleApp1
{
    class Program
    {
        struct SinhVien
        {
            public int MaSV_236;
            public string HoTen_236;
            public double DiemToan_236;
            public double DiemLy_236;
            public double DiemVan_236;
        }

        
        static void NhapDSSV(SinhVien[] MANGSV, int n)
        {
            for (int i = 0; i< n; i++)
            {
                Console.Clear();
                Console.WriteLine("Moi nhap thong tin sinh vien thu " + (i+1));
                Console.Write("Nhap Ma SV: ");
                MANGSV[i].MaSV_236 = int.Parse(Console.ReadLine());
                Console.Write(" Ho ten: ");
                MANGSV[i].HoTen_236 = Console.ReadLine();
                Console.Write(" Diem toan: ");
                MANGSV[i].DiemToan_236 = Double.Parse(Console.ReadLine());
                Console.Write(" Diem ly: ");
                MANGSV[i].DiemLy_236 = Double.Parse(Console.ReadLine());
                Console.Write(" Diem van: ");
                MANGSV[i].DiemVan_236 = Double.Parse(Console.ReadLine());
                Console.WriteLine("");

            }
        }

        static void XuatThongTinSinhVien(SinhVien[] MANGSV)
        {
            Console.Clear();
            Console.WriteLine("========Thong tin cac sinh vien da nhap la:====== ");
            foreach(SinhVien item in MANGSV){
                Console.WriteLine(" Ma Sinh Vien: " + item.HoTen_236);
                Console.WriteLine(" Ho ten: " +item.HoTen_236);
                Console.WriteLine(" Diem toan: " + item.DiemToan_236);
                Console.WriteLine(" Diem ly: " + item.DiemLy_236);
                Console.WriteLine(" Diem van: " + item.DiemVan_236);
                Console.WriteLine(" Diem trung binh la: " + DiemTBSinhVien(item));
                if( DiemTBSinhVien(item) > (int)HocLuc.Gioi)
                {
                    Console.WriteLine(" Hoc luc gioi ");
                }
                else
                {
                    if (DiemTBSinhVien(item) > (int)HocLuc.Kha)
                    {
                        Console.WriteLine(" Hoc luc kha ");
                    }
                    else
                    {
                        if (DiemTBSinhVien(item) > (int)HocLuc.TrungBinh)
                        {
                            Console.WriteLine(" Hoc luc trung binh ");
                        }
                        else
                        {
                            Console.WriteLine(" Hoc luc kem ");
                        }
                    }    
                }
               
            }
           
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan_236 + SV.DiemLy_236 + SV.DiemVan_236) / 3;
        }

        enum HocLuc
        {
            Kem = 4,
            TrungBinh = 5,
            Kha = 7,
            Gioi = 8
        }

        static void timKiemTheoTen(SinhVien[] MANGSV, char ten, int n)
        {
           


        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Moi nhap so luong sinh vien :");
            n = int.Parse(Console.ReadLine());
            SinhVien[] MANGSV = new SinhVien[n];
            NhapDSSV(MANGSV, n);
            XuatThongTinSinhVien(MANGSV);
            Console.ReadLine();
        }
    }
}
