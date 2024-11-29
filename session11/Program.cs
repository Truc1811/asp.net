using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Bai 1 Quan ly lop hoc 
        //1. class lop hoc de quan ly lop hoc 
        //bao gom class id , class name , danh sacch sinh vien trong lop
        //2. class ve sinh vien : student id, student name , tuoi 
        //3. yeu cau chuc nang : them sinh vien vao lop , hien thi danh sach sinh vien , tim sinh vien theo ma sinh vien 

        // tao lop hoc
        

        Classroom classroom = new Classroom("C02","DOTNET02");
        // //MENU 
        while (true){

            Console.WriteLine("==========Chuc nang chinh=============:");
            Console.WriteLine("\n 1. Them sinh vien");
            Console.WriteLine("\n 2. Hien thi danh sach sinh vien");
            Console.WriteLine("\n 3. Tim sinh vien theo ma sinh vien");
            Console.WriteLine("\n 4. Thoat");
            Console.WriteLine("\n Chon 1 trong cac chuc nang tren");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    // them sinh vien
                    Console.WriteLine("Nhap thong tin sinh vien:");
                    Console.WriteLine("Ma sinh vien: ");
                    string? studentId = Console.ReadLine();
                    Console.WriteLine("Ten sinh vien: ");
                    string? studentName = Console.ReadLine();
                    Console.WriteLine("Tuoi sinh vien: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(studentId, studentName, age);
                    //luu danh sach sinh vien vao json;
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);
                    // luu json vao file
                    File.WriteAllText("STUDENT.json", json);
                    Console.WriteLine("Save sucessfully");
                    classroom.AddStudent(student);
                    break;
                case 2:
                    // hien thi danh sach sinh vien
                    Console.WriteLine("Danh sach sinh vien trong lop:");
                    classroom.showStudent();
                    var studentsJson=File.ReadAllText("student.json");
                    classroom.students=JsonConvert.DeserializeObject<List<Student>>(studentsJson);
                    break;
                case 3: 
                    // tim sinh vien theo ma sinh vien
                    Console.WriteLine("Nhap ma sinh vien can tim:");
                    string? searchId = Console.ReadLine();
                    if(searchId==null){
                        Console.WriteLine("Ma sinh vien khong ton tai.");
                        break;
                    }
                    classroom.findStudentByStudentId(searchId);
                    break;
                case 4:
                // thoat
                    return;
               
            }
            //1 Tao book de quan ly sach
            //2. class book : id, name, author, price
            //3. yeu cau chuc nang : them sach, hien thi danh sach sach, tim sach theo id
        }
    

    }
}

