//Bai 1
#region 
//Input
//Hay nhap soi ngay vao
Console.WriteLine($"Hay nhap so ngay muon nhap vao)");
string ngay = Console.ReadLine();
//Covert ngay sang so

int ngayInt = Convert.ToInt32(ngay);
//Process

int tuan = ngayInt / 7;

int ngayle = ngayInt - tuan * 7;

//Output

Console.WriteLine($"Tong so tuan  {tuan}");

Console.WriteLine($"Tong so ngay le la {ngayle}");


#endregion


//Bai 2
#region 
//Input
Console.WriteLine("Hay nhap tong gia tri don hang can thanh toan");
string giatridonhang = Console.ReadLine();
Console.WriteLine("Hay nhap % gia tri giam gia");
string giatrigiamhgia = Console.ReadLine();
//Convert giatridonhang sang so
double giatridonhangDouble = Convert.ToDouble(giatridonhang);
double giatrigiamhgiaDouble = Convert.ToDouble(giatrigiamhgia);
double sotiengiamgia = (giatrigiamhgiaDouble / 100 * giatridonhangDouble);
double giatrithanhtoan = giatridonhangDouble - (giatridonhangDouble * giatrigiamhgiaDouble / 100);

//Process
//Output

Console.WriteLine($"Tong so tien giam gia la {sotiengiamgia}");
Console.WriteLine($"Gia tri thanh toan la {giatrithanhtoan}");

#endregion

//Bai 3
#region 
//Input
Console.WriteLine($"Hay nhap phut can chuyen doi ");

string phut = Console.ReadLine();

//process
double phutDouble = Convert.ToDouble(phut);

double gio=phutDouble/60;
double phutconlai=phutDouble%60;


//output
Console.WriteLine($"So gio la {gio}");
Console.WriteLine($"So phut la {phutconlai}");

#endregion


//Bai 4
#region 
//Input
Console.WriteLine($"Hay nhap so tien vao");

string sotien = Console.ReadLine();
double tien=Convert.ToDouble(sotien);
//Process

double tiensauthue=tien+tien*10/100;
//Output

Console.WriteLine($"So tien sau thue la {tiensauthue}");
#endregion

//Bai 5
#region 
//Input
Console.WriteLine($"Hay nhap tien USD vao");
string tien = Console.ReadLine();

Console.WriteLine($"Hay nhap ty gia vao");
string tygia = Console.ReadLine();

double tienDouble = Convert.ToDouble(tien);

double tygiaDouble = Convert.ToDouble(tygia);
//Process

double tienquydoi = tienDouble*tygiaDouble;
//Output
Console.WriteLine($"So tien sau khi quy doi {tienquydoi}");
#endregion