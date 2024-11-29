class Nguoi{
    public string ID;
    public string ten;
    public string GioiTinh;
    public string NgaySinh;
    public string Email;

    public Nguoi (string ID, string ten, string GioiTinh, string NgaySinh, string Email){
        this.ID = ID;
        this.ten = ten;
        this.GioiTinh = GioiTinh;
        this.NgaySinh = NgaySinh;
        this.Email = Email;
    }


    public virtual void inThongtin(){
        Console.WriteLine($"ID:{ID}");
        Console.WriteLine($"Ten: {ten}" );
        Console.WriteLine($"GioiTinh:{GioiTinh}");
        Console.WriteLine($"NgaySinh: {NgaySinh}" );
        Console.WriteLine($"Email:{Email} ");
    }

}