using System;
using System.Collections.Generic;

namespace Bai_Luyen_tx1._1
{
    internal class SERVICE
    {
        List<GiaoVien> ds_GiaoVien = new List<GiaoVien>();

        public void NhapDsGiaoVien()
        {
            int id;
            string name;
            double sogioday;
            string c;
            do {
                    Console.WriteLine("Nhap ID: ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Nhap so gio day: ");
                    sogioday = double.Parse(Console.ReadLine());
                    GiaoVien gv = new GiaoVien(id, name, sogioday);
                    ds_GiaoVien.Add(gv);
                    Console.WriteLine("Ban muon tiep tuc nhap (y/n)?");
                    c = Console.ReadLine();
            }
            while (c == "y");
        }

        public void Xuat()
        {
            Console.WriteLine("______Danh Sach Giao Vien______");
            Console.WriteLine("ID\tName\tGio_Day");
            foreach (GiaoVien x in ds_GiaoVien)
            {
                x.InThongTin();
            }
        }

        public void TimGV(double minHours, double maxHours)
        {
            Console.WriteLine("Danh Sach Giao Vien co so gio day trong khoang [{0}, {1}]:", minHours, maxHours);
            foreach (GiaoVien x in ds_GiaoVien)
            {
                if (x.SoGioDay > minHours && x.SoGioDay < maxHours)
                {
                    x.InThongTin();
                }
            }
        }

        public void Xoa(int ID)
        {
            int k = 0;
            for (int i = 0; i < ds_GiaoVien.Count; i++)
            {
                if (ds_GiaoVien[i].ID == ID)
                {
                    ds_GiaoVien.RemoveAt(i);
                    k++;
                    i--; // Adjust index to handle the shift after removal
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Khong tim thay giao vien co ID = {0}", ID);
            }
            else
            {
                Console.WriteLine("Danh sach giao vien sau khi xoa:");
                Xuat();
            }
        }
    }
}
