// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// //Học cộng trừ nhân chia , chia lấy phần nguyên, chia lấy phần dư
// // Khai báo biến

// #region 
// int add = 5 + 10;
// Console.WriteLine($"Kết quả cộng 2 số 5 và 10 là {add}");
// int minus = 12345 - 345;
// Console.WriteLine($"Kết quả trừ 12345 trừ 345 là {minus}");
// int multiply = 2 * 3;
// Console.WriteLine($"Kết quả nhân là {multiply}");
// double divide = 10 / 3;
// Console.WriteLine($"Kết quả chia là {divide}");
// #endregion



// #region

// int remainder = 10 % 3;
// Console.WriteLine($"Phần dư khi chia 10 cho 3 là {remainder}");

// int quotient = 10 / 3;
// Console.WriteLine($"Phần nguyên khi chia 10 cho 3 là {quotient}");


// int cong = 0;
// cong += 10;
// Console.WriteLine($"{cong}");
// #endregion

// #region
// // string str = "123";
// // int number = Convert.ToInt32(str)
// // Console.WriteLine($"Chuyển chuoi sang số {number}");
// #endregion


// #region ép kiểu dữ liệu

// //Convert
// //Nhập dữ liệu tưg bàn phím =>ReadLine (string)
// string number = Console.ReadLine();

// int convertNumber = Convert.ToInt32(number); // Convert

// Console.WriteLine($"Chuyển số {number} từ string sang int {convertNumber}");


// int sum = convertNumber + 1;
// Console.WriteLine($"Tổng là {convertNumber}");

// #endregion

// #region tÍNH CHỈ SỐ BMI
// //INPUT
// //Chiều cao và cân nặng được nhập từ bàn phím
// Console.WriteLine($"Mời bạn nhập vào chiều cao ");
// string chieuCao = Console.ReadLine();
// //Convert String sang Double

// double chieuCaoDouble = Convert.ToDouble(chieuCao);

// Console.WriteLine($"Mời bạn nhập vào cân nặng ");
// string canNang = Console.ReadLine();

// //Convert String sang Double

// double canNangDouble = Convert.ToDouble(canNang);


// //OUTPUT
// double BMI = 0.0;//Khởi tạo biến BMI để lưu giá trị

// //Tính chỉ số BMI

// BMI = canNangDouble / (chieuCaoDouble * chieuCaoDouble);




// //In ra chỉ số BMI


// Console.WriteLine($"Chỉ số BMI của bạn là {BMI}");

// #endregion



#region
//INPUT
// Hãy nhập bán kính hình tròn
Console.WriteLine($"Hãy nhập bán kính vào");

string banKinh = Console.ReadLine();

//Convert String sang Double

double banKinhDouble = Convert.ToDouble(banKinh);


//PROCESS
//Chu vi hình tròn
double chuVi=0.0;
double dienTich = 0.0;
chuVi = 2 * Math.PI * banKinhDouble;

//Diện tích hình tròn

 dienTich = Math.PI * banKinhDouble * banKinhDouble;

//OUTPUT

Console.WriteLine($"Chu vi của hình tròn là {chuVi}");

Console.WriteLine($"Diện tích của hình tròn là {dienTich}");



#endregion