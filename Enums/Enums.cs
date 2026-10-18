using System;

namespace DotNetTutorials.Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee() { Name = "Anurag", Gender = 0 },
                new Employee() { Name = "Pranaya", Gender = 1 },
                new Employee() { Name = "Priyanka", Gender = 2 },
                new Employee() { Name = "Sambit", Gender = 3 }
            };

            foreach (var emp in empList)
            {
                Console.WriteLine($"Name = {emp.Name} && Gender = {GetGender(emp.Gender)}");
            }

            Console.ReadLine();
        }

        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid Data for Gender";
            }
        }
    }
    
    public class Employee
    {
        public string Name { get; set; }

        // 0 - Unknown
        // 1 - Male
        // 2 - Female
        public int Gender { get; set; }
    }
}