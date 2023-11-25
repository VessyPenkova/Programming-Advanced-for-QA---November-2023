namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {

            int numbersOFLine = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numbersOFLine; i++)
            {
                string [] inputInfo = Console.ReadLine().Split(" ").ToArray();
                string firstName = inputInfo[0];
                string secondName = inputInfo[1];
                double grade = double.Parse(inputInfo[2]);

                Student currentStudent = new Student(firstName, secondName, grade);
                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in orderedStudents) 
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:f2}");
            }

        }
     
    }

}
