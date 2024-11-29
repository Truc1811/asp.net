class Nhanvien
{
    protected string manv;
    private string ten
    {get; set; }
    //muc dich dung get set de truy cap thuoc tinh private
    public string ngaysinh;
    public int tuoi;
    public double luong;
    public string gioitinh;

    public string MaQLnhom;

    //BT ôn lại
    //Sinh viên , giảng viên , cán bộ trong trường học
    //Viết chương trình quản lý những đối tượng trên
    //class nguoi :id , ma , ten , ngay sinh , gioitinh , email
    //sinh vien:id, ten , ma , ngay sinh, gt, email
    //giảng viên: id, ten, ma, ngay sinh, gt, email
    //cán bộ: id, ten, ma, ngay sinh, gt, email,chức vụ , phòng ban 
    //overload:nap chong len phuong thuc
    //overide: ghi de len phuong thuc 
    public virtual double tinhLuong(){
        return 1000;
    }

}