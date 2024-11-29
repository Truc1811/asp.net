class Classroom{
    // thuoc tinh
    public string classId;
    public string className;
    public List<Student> students;
    public Classroom (string classId, string className){
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();
    }
    //Phuong thuc them sinh vien vao lop
    public void AddStudent(Student student){
        students.Add(student);
        Console.WriteLine($"{student.studentName} added to {className} ");

    }

    public void showStudent(){
        Console.WriteLine($"\n Class: {className}");
        foreach(Student student in students){
            student.showInfo();
        }
    }

    public void findStudentByStudentId(string studentId){
        foreach(Student student in students){
            //C1
            if(student.studentId == studentId){
                student.showInfo();
                return;
            }
        }
        Console.WriteLine("Student not found!");
    }

}