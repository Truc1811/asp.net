class Student{
    public string studentId;
    public string studentName;
    public int age;

    public Student (string studentId, string studentName, int age){
        this.studentId = studentId;
        this.studentName = studentName;
        this.age = age;
    }

    // phuong thuc hien thi thong tin sinh vien
    public void DisplayStudentInfo(){
        Console.Write($"Student ID: {studentId}");
        Console.Write($"Student Name: {studentName}");
        Console.Write($"Age: {age}");
    }
    //donet publish -c Release -r win-x64 --self-contained true
}