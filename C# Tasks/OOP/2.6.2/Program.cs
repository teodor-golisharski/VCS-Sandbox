namespace _2._6._2
{
    class Student 
    {
        public Student(string name, string city)
        {
            Name = name;
            City = city;
        }

        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            StreamReader reader = new StreamReader("birthPlace.txt");
            using(reader)
            {
                while(!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine()!.Split(" - ");
                    Student student = new Student(line[0], line[1]);
                    students.Add(student);
                }
            }

            Console.WriteLine(students
                .GroupBy(x => x.City)
                .OrderByDescending(x => x.Count())
                .First()
                .Count());
        }
    }
}