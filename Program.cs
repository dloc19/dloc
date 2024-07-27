using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Luyen_tx1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SERVICE GV = new SERVICE();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap danh sach giao vien");
                Console.WriteLine("2. Xuat danh sach giao vien");
                Console.WriteLine("3. Tim kiem ds sach theo khoang");
                Console.WriteLine("4. Xoa giao vien theo ID");
                Console.WriteLine("Moi ban nhap lua chon:");

                if (int.TryParse(Console.ReadLine(), out int k))
                {
                    switch (k)
                    {
                        case 0:
                            Console.WriteLine("Ket thuc chuong trinh.");
                            return;
                        case 1:
                            GV.NhapDsGiaoVien();
                            break;
                        case 2:
                            GV.Xuat();
                            break;
                        case 3:
                            try
                            {
                                Console.WriteLine("Nhap gia tri dau a = ");
                                int a = int.Parse(Console.ReadLine());
                                Console.WriteLine("Nhap gia tri cuoi b = ");
                                int b = int.Parse(Console.ReadLine());
                                GV.TimGV(a, b);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap lai.");
                            }
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Nhap ID can xoa: ");
                                int ID = int.Parse(Console.ReadLine());
                                GV.Xoa(ID);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("ID nhap vao khong hop le. Vui long nhap lai.");
                            }
                            break;
                        default:
                            Console.WriteLine("Ban nhap sai lua chon. Vui long chon lai.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang. Vui long nhap so.");
                }
            }
        }
    }
}