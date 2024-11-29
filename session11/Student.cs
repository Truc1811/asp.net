class Student{
    public string studentId;
    public string studentName;
    public int tuoi;
    public Student(string studentId, string studentName, int tuoi){
        this.studentId = studentId;
        this.studentName = studentName;
        this.tuoi = tuoi;
    }
    // phuong thuc hien thi thong tin sinh vien 
    public void showInfo(){
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + tuoi);
    }

}