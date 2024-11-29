internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // SanPham sanPham = new SanPham();
        // sanPham.nhapThongTin();
        // sanPham.xuatThongTin();


        // 4 tinh chat trong OP
        //Tinh ke thua
        //Tinh khoi tao
        //Tinh dong goi
        //Tinh phuong thuc
        Truongnhom truongnhom = new Truongnhom();
        // truongnhom.ten  = "Nguyen Van Teo";
        // truongnhom.manv="NV001";
        // Console.WriteLine($"Tên trưởng nhóm {truongnhom.ten}");
        // Console.WriteLine($"Tên trưởng nhóm {truongnhom.manv}");
        QuanLy quanLy = new QuanLy();
        Console.WriteLine(quanLy.tinhLuong());
        quanLy.luong = 10000;
        Console.WriteLine($"luong quan ly:{quanLy.luong}");
        //C# check class quan ly de lam thuoc tinh luong
        //neu khong co thi check cha (Truong nhom)
        //neu khong co thi check class cha cua class cha (nhan vien)
        Truongnhom TruongNhom=new Truongnhom();
        Console.WriteLine(TruongNhom.tinhLuong());
        // Luu y override : neu ma class con khong muon dung cac logic cua phuong thuc class cha thi thang con co the trong class con
        //neu class con muon dung lai logic cua class cha
        //có the dung phuong thuc base.tinhLuong() de goi phuong thuc class cha

        Sinhvien sinhvien = new Sinhvien("SV001","Nguyen Van A","Nam","20/02/2022","lillyclover2gmail.com","IT001",8.02);
        Console.WriteLine($"Ten sinh vien: {sinhvien.ten}");
        Console.WriteLine($"Ten sinh vien: {sinhvien.ID}");
        Console.WriteLine($"Ten sinh vien: {sinhvien.diemtrungbinh}");


    }
}