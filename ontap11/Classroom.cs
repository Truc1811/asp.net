class Classroom{
    //thuoc tinh 
    public string classId;
    public string className;
    public List<Student> students ;
    

    public Classroom(string classId, string className){
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();
    }

    // Phuong thuc them sinh vien vao nhom
    public void AddStudent(Student student){
        students.Add(student);
        Console.WriteLine($"Sinh vien {student.studentName} da duoc them vao lop");
    }
    
    //Phuong thuc tim kiem sinh vien theo ma sinh vien 
    public void FindStudentById(string studentId)
    {
        //C1 : Dung vong lap
        Console.Write("Nhap ma sinh vien can tim: ");
        foreach(Student student in students){
            if(student.studentId==studentId){
                student.DisplayStudentInfo();
                return;
            }
        }
        Console.WriteLine($"Sinh vien co ma {studentId} khong ton tai");
    }

    // Phuong thuc hien thi danh sach sinh vien
    public void DisplayStudents()
    {
        foreach (Student student in students)
        {
            student.DisplayStudentInfo();
        }
    }
}