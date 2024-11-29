// #region 
// //In ra cac so tu 1 den n duoc nhap tu ban phim
// //Khoi tao gia tri can lap
// Console.WriteLine("Hay nhap gia tri n vao ");
// string ?number=Console.ReadLine();
// int formatnumber=Convert.ToInt32(number);
// //Xac dinh dieu kien lap
// //Thay doi gia tri lap
// int count=1;
// while(count <=formatnumber){
//     Console.WriteLine(count);
//     count++;
// }
// #endregion

// #region 
// //S=1+2+3+4+5+6+7+8+N
// //Khoi tao gia tri
// Console.WriteLine("Hay nhap gia tri n vao:");
// string ?so=Console.ReadLine();
// int formatso = Convert.ToInt32(so);
// //Tinh tong
// int dem=1;
// int tong=0;


// while(dem<=formatso){
//     tong=tong+dem;
//     dem++;
// }
// Console.WriteLine($"Tong cac so tu 1 den n la {tong}");
// #endregion


// #region 
// //Tinh giai thua so n 
// //Khoi tao gia tri
// Console.WriteLine("Hay nhap gia tri so nguyen n vao : ");
// string ?number=Console.ReadLine();
// int formatnumber= Convert.ToInt32(number);
// int count=1;
// int tich=1;
// while(count<=formatnumber){
//     tich=tich*count;
//     count++;
// }
// Console.WriteLine($"Tich cac so tu 1 den {number} la {tich}");

// #endregion
// #region 
// //In bang cuu chuong 
// Console.WriteLine("Hay nhap gia tri n vao: ");
// string ?number = Console.ReadLine();
// int formatnumber=Convert.ToInt32(number);
// int count=1;

// while(count<=10){
//     Console.WriteLine($"Tich cua {number} * {count} la {formatnumber*count}");
//     count++;
// }

// #endregion


// #region 
// //Khoi tao gia tri
// Console.WriteLine("Hay nhap gia tri n vao:");
// string ?number= Console.ReadLine();
// int formatnumber=Convert.ToInt32(number);
// //xac dinh vong lap
// int count=2;
// while(count<=formatnumber){
//     if(formatnumber % count==0){
//         Console.WriteLine($"{formatnumber} khong la so nguyen to");
//         break;
//     }
//     count++;
// }

// if(count==formatnumber){
//      Console.WriteLine($"{formatnumber} la so nguyen to");
// }

// #endregion


// #region 
// //Khoi tao gia tri 
// Console.WriteLine("Hay nhap gia tri n ");
// string ?number=Console.ReadLine();

// int formatnumber=Convert.ToInt32(number);
// // In bang cuu chuong
// for (int i =1; i<=10;i++){
//     Console.WriteLine($"Tich cua {formatnumber} * {i} la {formatnumber*i}");
// }

// #endregion


// #region 
// //Khoi tao gia tri
// Console.WriteLine("Hay nhap gia tri n vao :");
// string ?nummber=Console.ReadLine();
// int formatnumber=Convert.ToInt32(nummber);
// int count;
// for(count=2;count<formatnumber;count++){
//     if(formatnumber%count==0){
//         Console.WriteLine($"{formatnumber} la khong la so nguyen to");
//         break;
//     }
// }
// if(count==formatnumber){
//     Console.WriteLine($"{formatnumber} la so nguyen to");
// }

// #endregion


// #region 
// Console.WriteLine("Hay nhap chieu cao cua tam giac");
// string ?number= Console.ReadLine();

// int formatnumber=Convert.ToInt32(number);

// for(int i=0;i<formatnumber;i++){
//     for(int j=0;j<formatnumber - i - 1;j++){
//         Console.Write("-");
//     }
//     for(int k=0;k<(2*i+1);k++){
//         Console.Write("*");
//     }
//     Console.WriteLine("");

// }
// #endregion

#region 
//1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n")
using System.Globalization;
int number 
=Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <number;i++){
    bool isPrime = true;
    for (int j = 2; j <=Math.Sqrt(i); j++){
        if (i % j == 0){
            isPrime = false;
            break;
        }
    }
    if (isPrime){
        Console.WriteLine(i);
    }

}
#endregion

#region
// 2: Nhập chiều cao tam giác. In ra tam giác cân rỗng");
//   __*
//   _* *
// __*   *
// _*     *
// *********
#endregion
// Console.WriteLine("Hay nhap chieu cao cua tam giac");
// // string ?cao = Console.ReadLine();
// // int formatcao =Convert.ToInt32(cao);
// // for(int i = 0; i <formatcao; i++){
// //     for(int j = 0; j < formatcao - i - 1; j++){
// //         Console.Write(" ");
// //     }
// //     for(int k = 0; k <i; k++){
// //         Console.Write("*");
// //     }
// //     Console.WriteLine(" ");
// // }


#region 
Console.WriteLine("Hay nhap so nguyen "); 
string ?number = Console.ReadLine();

int formatnumber = Convert.ToInt32(number);
int reversNumber = 
while(number>0){
    int remainder = number % 10;
    
    number /= 10;
}


#endregion