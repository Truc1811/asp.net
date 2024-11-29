// See https://aka.ms/new-console-template for more information

#region 
//If else statement
//Nhập số nguyên từ bàn phhism và in ra từ bàn phím là số lẻ hay số số chẵn
// Console.WriteLine($"Hay nhap 1 so tu ban phim");
// string? number=Console.ReadLine();

// int formatNumber=Convert.ToInt32(number);
// if(formatNumber%2==0){
//     Console.WriteLine($"{formatNumber} la so chan");
// }
// else{
//     Console.WriteLine($"{formatNumber} la so le");
// }

//truthy
// int day=5;
// if(day!=0){
//  Console.WriteLine("Truthy");
// }
// // Hãy nhập học lực của 1 sinh viên
// //>=9 :Xuất sắc
// //8<=diem <9;gioi
// //6.5 <=diem<8:kha
// //5<=diem <6.5:trunhbinh
// //3.5<=diem<5:yeu
// //quakem

// Console.WriteLine("Hay nhap diem cua sinh vien");
// string? score=Console.ReadLine();

// double formatScore=Convert.ToDouble(score);
// if(formatScore>=9){
//     Console.WriteLine("Xuat sac");
// }
// else if
// (8<=formatScore && formatScore<9){
//     Console.WriteLine("Gioi");
// }
// else if(6.5<=formatScore && formatScore<8){
//     Console.WriteLine("Kha");
// }
// else if(5<=formatScore && formatScore<6.5){
//     Console.WriteLine("Trung binh");
// }
// else if(3.5<=formatScore && formatScore<5){
//     Console.WriteLine("Yeu");
// }
// else {
//     Console.WriteLine("Qua kem");
// }


//Hay nhap 3 so vao tinh tong 3 chu so
//Neu khong phai 3 chu so se loi
Console.WriteLine($"Hay nhap 1 so vao");

string? input1=Console.ReadLine();

int number=Convert.ToInt32(input1);
int sum = 0;
int lastDigit = 0;
if (number>100 && number<1000 ){
    while(number>0){
         lastDigit=number%10;
        sum+=lastDigit;
        number=number/10;
    }
    Console.WriteLine($"Tong cac chu so la: {sum}");
}
else {
    Console.WriteLine($"Khong phai 3 chu so");
}

//Nhap ngay thang nam , in ra thu may trong tuan


#endregion
