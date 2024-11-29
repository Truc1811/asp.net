class BaiViet{
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;

    //default khi khoi tao doi tuong thi C# se goi ham khoi tao (constructor) mac dinh
    //ham khoi tao nay se tao gia tri mac dinh cho cac thuoc tinh
    //cu phap <tenclass> (){}
    public BaiViet(){
        Console.WriteLine("Day la ham khoi tao "); 
    }//Khoi tao constructor

    public BaiViet(string tieuDe, string noiDung, string hinhAnh){
        this.tieuDe = tieuDe;
        this.noiDung = noiDung;
        this.hinhAnh = hinhAnh;
    }

    public BaiViet(BaiViet other){
        this.tieuDe = other.tieuDe;
        this.noiDung = other.noiDung;
        this.hinhAnh = other.hinhAnh;
    }


    public void xuatThongTin(){
        Console.WriteLine("Thong tin bai viet la :");
        Console.WriteLine($"Tieu de: {tieuDe}");
        Console.WriteLine($"Hinh anh: {hinhAnh}");
        Console.WriteLine($"Hinh anh: {noiDung}");
    }

}