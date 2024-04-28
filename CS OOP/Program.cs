// See https://aka.ms/new-console-template for more information
class Student
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public Student(string name, string major, double gpa)
    {
        Name = name;
        Major = major;
        GPA = gpa;
    }

    public void StudentSummary()
    {
        Console.WriteLine($"Name: {Name}\nMajor: {Major}\nGPA: {GPA}");
    }
}
//Bonus
class GraduateStudent : Student
{
    public string ThesisTopic { get; set; }

    public GraduateStudent(string name, string major, double gpa, string thesisTopic)
        : base(name, major, gpa)
    {
        ThesisTopic = thesisTopic;
    }

    public new void StudentSummary()
    {
        base.StudentSummary();
        Console.WriteLine($"Thesis Topic: {ThesisTopic}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student undergrad = new Student("Othman", "Information Systems Technology", 3.8);
        undergrad.StudentSummary();

        GraduateStudent gradStudent = new GraduateStudent("Saleh", "Information Systems Technology", 3.9, "Advanced System Analysis");
        gradStudent.StudentSummary();
    }
}
