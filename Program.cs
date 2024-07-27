using System;
using System.Collections.Generic;

public class Program
{
    private static List<KhachHang> danhSachKhachHang = new List<KhachHang>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Nhap thong tin");
            Console.WriteLine("2. Hien thi danh sach");
            Console.WriteLine("3. Xoa khach hang");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon mot chuc nang: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    NhapThongTin();
                    break;
                case 2:
                    HienThiDanhSach();
                    break;
                case 3:
                    XoaKhachHang();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }

    private static void NhapThongTin()
    {
        Console.WriteLine("1. Khach hang thuong");
        Console.WriteLine("2. Khach hang VIP");
        Console.Write("Chon loai khach hang: ");
        int loaiKhachHang = int.Parse(Console.ReadLine());

        Console.Write("Nhap ma khach hang: ");
        string maKhachHang = Console.ReadLine();

        Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
        DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Nhap so luong mua: ");
        int soLuongMua = int.Parse(Console.ReadLine());

        Console.Write("Nhap don gia: ");
        double donGia = double.Parse(Console.ReadLine());

        if (loaiKhachHang == 1)
        {
            danhSachKhachHang.Add(new KhachHang(maKhachHang, ngaySinh, soLuongMua, donGia));
        }
        else if (loaiKhachHang == 2)
        {
            danhSachKhachHang.Add(new KhachHangVIP(maKhachHang, ngaySinh, soLuongMua, donGia));
        }
    }

    public static void HienThiDanhSach()
    {
        foreach (var khachHang in danhSachKhachHang)
        {
            Console.WriteLine(khachHang);
        }
    }

    public static void XoaKhachHang()
    {
        Console.Write("Nhap ma khach hang can xoa: ");
        string MaKhachHang = Console.ReadLine();

        for (int i = 0; i < danhSachKhachHang.Count; i++)
        {
            if (danhSachKhachHang[i].maKhachHang == "MaKhachHang")
            {
                danhSachKhachHang.RemoveAt(i);
                break;
            }
        }
    }
}
