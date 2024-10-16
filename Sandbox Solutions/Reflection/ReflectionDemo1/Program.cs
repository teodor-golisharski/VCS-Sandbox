using System.Reflection;

namespace ReflectionDemo1
{
    internal class Program
    {
        class Student
        {
            private string name;
            private int grade;
            public Student(string name, int grade)
            {
                this.name = name;
                this.grade = grade;
            }

            public string Name { get; set; } = null!;
            public int Grade { get => grade; } 
        }

        static void Main(string[] args)
        {
            Type type = typeof(Student);

            PropertyInfo[] fields = type.GetProperties();

            foreach (PropertyInfo field in fields)
            {
                Console.WriteLine(field.Name);
                Console.WriteLine(field.PropertyType);
            }

            ConstructorInfo[] allConstructos = type.GetConstructors();

            foreach (ConstructorInfo constructor in allConstructos)
            {
                Console.WriteLine(constructor.GetParameters()[0].ToString());
            }
        }
    }
}
