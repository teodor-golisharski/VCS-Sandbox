using System.Reflection;

namespace ReflectionDemo1
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; } = null!;
            public int Grade { get; set; } 
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
        }
    }
}
