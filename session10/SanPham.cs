class SanPham
{

    public string maSanPham;
    public string tenSanPham;
    public string giaSanPham;
    public string soluong;

    public void nhapThongTin()
    {
        Console.WriteLine("Nhập mã sản phẩm");
        maSanPham = Console.ReadLine();


        Console.WriteLine("Nhập ten sản phẩm");
        tenSanPham = Console.ReadLine();


        Console.WriteLine("Nhập gia sản phẩm");
        giaSanPham = Console.ReadLine();


        Console.WriteLine("Nhập  sản phẩm");
        soluong = Console.ReadLine();

    }


    public void xuatThongTin()
    {
        Console.WriteLine($" mã sản phẩm : {maSanPham}");

        Console.WriteLine($" Nhập sl sản phẩm: {tenSanPham}");



        Console.WriteLine($" Nhập gia sản phẩm: {giaSanPham}");



        Console.WriteLine($" Nhập sl sản phẩm: {soluong}");

        Console.WriteLine("Nhập sl sản phẩm");


    }

}