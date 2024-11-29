class Truongnhom : Nhanvien
{

    public string MaQLnhom;
    public string getMaNV()
    {
        return this.manv;
    }

    public override double tinhLuong()
    {
        double luongcoban=base.tinhLuong();
        return luongcoban + 1.5 * luongcoban;
    }


}