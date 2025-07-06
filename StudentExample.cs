
namespace Module3Assignment
{
    public class Student
    {
        public string Name;
        public int ID;
        public double GPA;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"GPA: {GPA:F2}");
        }

        public int GetRoundedGPA()
        {
            // Type casting example
            return (int)GPA;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Maya Rivera";
            student1.ID = 2025;
            student1.GPA = 3.67;

            student1.DisplayInfo();

            int roundedGPA = student1.GetRoundedGPA();
            Console.WriteLine($"Rounded GPA (int): {roundedGPA}");
        }
    }
}
