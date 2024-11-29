class SanPham{
    public string masanpham;
    public string tensanpham;
    public double giasanpham;
    public int soluongton;

    public void nhapSanPham(){
        Console.Write("Nhap ma san pham: ");
        masanpham = Console.ReadLine();
        Console.Write("Nhap ten san pham: ");
        tensanpham = Console.ReadLine();
        Console.Write("Nhap gia san pham: ");
        giasanpham = double.Parse(Console.ReadLine());
        Console.Write("Nhap so luong ton: ");
        soluongton = int.Parse(Console.ReadLine());
    }
    public void xuatSanPham(){
        Console.WriteLine("Ma san pham: " + masanpham);
        Console.WriteLine("Ten san pham: " + tensanpham);
        Console.WriteLine("Gia san pham: " + giasanpham);
        Console.WriteLine("So luong ton: " + soluongton);
    }

}