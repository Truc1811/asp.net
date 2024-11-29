class QuanLy : Truongnhom
{
    public string ThuKy;
    public override double tinhLuong()
    {
        double luongcoban = base.tinhLuong();
        return luongcoban + 1.5 * luongcoban + 500;
    }

}