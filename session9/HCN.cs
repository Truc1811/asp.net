class HCN {
    public double chieudai;
    public double chieurong;

    public void nhapThongHCN(){
        Console.Write("Nhap chieu dai: ");
        chieudai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        chieurong = double.Parse(Console.ReadLine());
    }
    public double tinhDienTich(){
        return chieudai * chieurong;
    }
    public double tinhChuVi(){
        return 2 * (chieudai + chieurong);
    }
}