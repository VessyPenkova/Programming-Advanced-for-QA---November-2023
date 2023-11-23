namespace _02.__Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] commandParts = command.Split(" ");
                string firstName = commandParts[0];
                string lastName = commandParts[1];
                int age = int.Parse(commandParts[2]);
                string homeTown = commandParts[3];

                Student currentStudent
               = new Student(firstName, lastName, age, homeTown);

                students.Add(currentStudent);

                command = Console.ReadLine();
            }

            string targetcity = Console.ReadLine();

            List<Student> filteredStudents =
                students.Where(x => x.HomeTown == targetcity).ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}
