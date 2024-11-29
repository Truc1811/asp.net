class HocSinh{
    public string TenHocSinh;
    public int tuoi;
    public string gioiTinh;
    public string email;
    public void nhapThongTinHocSinh(){
        Console.WriteLine("Nhap ten hoc sinh: ");
        TenHocSinh = Console.ReadLine();
        Console.WriteLine("Nhap tuoi: ");
        tuoi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gioi tinh: ");
        gioiTinh = Console.ReadLine();
        Console.WriteLine("Nhap email: ");
        email = Console.ReadLine();
    }

    public void InThongTinHocSinh(){

        Console.WriteLine("Thong tin hoc sinh:");
        Console.WriteLine("Ten hoc sinh: " + TenHocSinh);
        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("Gioi tinh: " + gioiTinh);
        Console.WriteLine("Email: " + email);
    } 
}