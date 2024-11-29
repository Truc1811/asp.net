using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BaiViet baiviet1 = new BaiViet();
        baiviet1.tieuDe = "Tổng Bí thư: Bộ máy sau sắp xếp phải hoạt động ngay";
        baiviet1.noiDung = "Tổng Bí thư Tô Lâm yêu cầu bộ máy mới sau khi sắp xếp tinh gọn phải tốt hơn cũ, đi vào hoạt động ngay, không để ngắt quãng công việc.";
        baiviet1.hinhAnh = "hinh1.png";
        baiviet1.xuatThongTin();
        Console.WriteLine("=============================");
        // Console.WriteLine($"Bai viet 1: {baiviet1.hinhAnh}, {baiviet1.hinhAnh}, {baiviet1.noiDung}");
        BaiViet baiviet2 = new BaiViet();
        baiviet2.tieuDe = "Có thể đánh thuế mua bán nhà đất theo thời gian sở hữu";
        baiviet2.noiDung = "Bộ Tài chính đề xuất đánh thuế thu nhập cá nhân từ chuyển nhượng bất động sản theo thời gian sở hữu để tránh đầu cơ như một số nước.";
        baiviet2.hinhAnh = "hinh2.png";
        baiviet2.xuatThongTin();
        Console.WriteLine("=============================");
        // Console.WriteLine($"Bai viet 2: {baiviet2.hinhAnh}, {baiviet2.hinhAnh}, {baiviet2.noiDung}");

        BaiViet baiviet3 =new BaiViet(baiviet1);
        Console.WriteLine($"kiem tra: {baiviet3==baiviet1}");
        baiviet3.hinhAnh="hinhanh3.png";
        Console.WriteLine(baiviet1.hinhAnh);
        
        BaiViet baiviet4=new BaiViet();
        baiviet4.hinhAnh=baiviet1.hinhAnh;
        baiviet4.noiDung=baiviet1.noiDung;
        baiviet4.tieuDe=baiviet1.tieuDe;
        Console.WriteLine($"kiem tra: {baiviet4==baiviet1}");

        BaiViet baiviet5= new BaiViet();
        Console.WriteLine($"Gia tri mac dinh cua thuoc tinh noi dung:{baiviet5.noiDung}");


        //Bai tap nhap mon;
        // Tao doi tuong hoc sinh (ho ten , tuoi , gioi tinh , email);
        //Xuat thong tin hoc sinh
        HocSinh hocsinh =new HocSinh();
        hocsinh.nhapThongTinHocSinh();
        hocsinh.InThongTinHocSinh();


        //bai tap ve nha luyen them
        //bai 1: tao doi tuong san pham (ma san pham , ten san pham , gia ban , so luong ton kho);
        //nhap va xuat thong tin san pham
        SanPham sanpham1 = new SanPham();
        sanpham1.nhapSanPham();
        sanpham1.xuatSanPham();

        //bai 2 :
        //Tao lop rec voi cac thuoc tinh:
        //length chieudai
        //width
        //va cac phuong thuc
        // Tinh dien tich
        //Tinh chu vi
        HCN rec1 = new HCN();
        rec1.nhapThongHCN();
        Console.WriteLine($"Dien tich: {rec1.tinhDienTich()}");
        Console.WriteLine($"Chu vi: {rec1.tinhChuVi()}");
       
    }
}