class  Sinhvien:Nguoi{
    
    public string lop;
    public double diemtrungbinh;
    public Sinhvien  (
       string ID,
       string ten,
       string ngaySinh,
       string GioiTinh,
       string email,
       string lop,
       double diemtrungbinh
       

    ):base( ID, ten, GioiTinh, ngaySinh, email)
    {
        
        this.lop = lop;
        this.diemtrungbinh = diemtrungbinh;
    }

    public override void inThongtin()
    {
        base.inThongtin();
        Console.WriteLine($"L��p: {lop}");
        Console.WriteLine($"Điểm trung bình: {diemtrungbinh}");
    }
};