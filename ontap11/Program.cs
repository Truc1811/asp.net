using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // #region Bai 1
        //B1 : Quan ly lop hoc
        // 1.lop hoc :
        //Tao lop classroom
        // class id :ten lop hoc
        //class name : ten lop hoc
        // danh sach sinh vien trong lop 
        //2.Sinh vien 
        // student id : ma sinh vien 
        // student name : ten sinh vien
        //age : tuoi
        //3. yeu cau chuc nang:
        //-Them sinh vien vao lop
        //-Hien thi danh sach sinh vien
        //-Tim sinh vien theo ma sinh vien 
        //Tao lop hoc
        Classroom classroom = new Classroom("001", "Lop1");
        while (true)
        {
            Console.WriteLine("==============================:");
            Console.WriteLine("Chuc nang quan ly lop hoc:");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. Tim sinh vien theo ma sinh vien");
            Console.WriteLine("4. Thoat");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Nhap ma sinh vien: ");
                    string? studentId = Console.ReadLine();
                    Console.Write("Nhap ten sinh vien: ");
                    string? studentName = Console.ReadLine();
                    Console.Write("Nhap tuoi sinh vien: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(studentId, studentName, age);
                    classroom.AddStudent(student);
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);
                    File.WriteAllText("student.json", json);
                    Console.WriteLine(" Adding successful");
                    // luu danh sach sinh vien sao json
                    //chuyen json sang string 
                    break;

                case 2:
                     //doc danh sach sinh vien tu file json
                     var studentjson=File.ReadAllText("student.json");
                     classroom.students =JsonConvert.DeserializeObject<List<Student>>(studentjson);
                     classroom.DisplayStudents();
                    break;
                case 3:
                    Console.Write("Nhap ma sinh vien can tim: ");
                    string? searchId = Console.ReadLine();
                    if (searchId == null)
                    {
                        Console.WriteLine("Ma sinh vien khong tim thay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Tim thay sinh vien ma {searchId}:");
                        classroom.FindStudentById(searchId);
                        break;
                    }
                case 4:
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }


        // #endregion


        // #region Bai 2
        //Quan ly thu vien
        //bookid : ma sach
        //bookname : ten sach
        //author : tac gia
        //year : nam xuat ban
        //yeu cau chuc nang:
        //-Them sach vao thu vien
        //-Hien thi danh sach sach
        //-Tim sach theo ma sach
        //Tao thu vien
        // Library library = new Library("001","Lop1");
        // while (true)
        // {
        //         Console.WriteLine("==============================:");
        //         Console.WriteLine("Chuc nang quan ly lop hoc:");
        //         Console.WriteLine("1. Them sach");
        //         Console.WriteLine("2. Hien thi danh sach ");
        //         Console.WriteLine("4. Thoat");
        //         int choice = Convert.ToInt32(Console.ReadLine());
        //         switch(choice){
        //             case 1:
        //                 Console.Write("Nhap ma sach: ");
        //                 string? bookId = Console.ReadLine();
        //                 Console.Write("Nhap ten sach: ");
        //                 string? bookname = Console.ReadLine();
        //                 Console.Write("Nhap tac gia: ");
        //                 string? author = Console.ReadLine();
        //                 Console.Write("Nhap nam phat hanh: ");
        //                 int year = Convert.ToInt32(Console.ReadLine());
        //                 Book book= new Book(bookId, bookname, author, year);
        //                 library.AddBook(book);
        //                 // luu danh sach sinh vien sao json
        //                 //chuyen json sang string 
        //                 break;

        //             case 2:
        //                 library.showBook();
        //                 break;
        //             case 4:
        //                 break;
        //             default:
        //                 Console.WriteLine("Lua chon khong hop le!");
        //                 break;
        //         }
        //     }
        //     #endregion
    }
}