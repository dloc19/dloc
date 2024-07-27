using System;

public class KhachHang
{
    private string maKhachHang;
    private DateTime ngaySinh;
    private int soLuongMua;
    private double donGia;

    public KhachHang(string maKhachHang, DateTime ngaySinh, int soLuongMua, double donGia)
    {
        this.maKhachHang = maKhachHang;
        this.ngaySinh = ngaySinh;
        this.soLuongMua = soLuongMua;
        this.donGia = donGia;
    }

    public double TinhTongTien()
    {
        return soLuongMua * donGia;
    }

    public override string ToString()
    {
        return $"Ma khach hang: {maKhachHang}, Ngay sinh: {ngaySinh.ToShortDateString()}, So luong mua: {soLuongMua}, Don gia: {donGia}, Tong tien: {TinhTongTien()}";
    }
}

public class KhachHangVIP : KhachHang
{
    public KhachHangVIP(string maKhachHang, DateTime ngaySinh, int soLuongMua, double donGia)
        : base(maKhachHang, ngaySinh, soLuongMua, donGia)
    {
    }

    public new double TinhTongTien()
    {
        double tongTien = base.TinhTongTien();
        if (tongTien <= 1000)
        {
            return tongTien * 0.9;
        }
        else
        {
            return tongTien * 0.8;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $", Tien phai tra sau giam gia: {TinhTongTien()}";
    }
}
