
using System;

namespace DotNetTutorials.Indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }

    public class Company
    {
        // Create variable to hold the list of employees.
        private List<Employee> _employees = new List<Employee>();

        // Initialize the employee list through the constructor.
        public Company()
        {
            _employees.Add(new Employee { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            _employees.Add(new Employee { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            _employees.Add(new Employee { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
        }

        // Integer indexer: returns or changes an employee's name.
        public string this[int employeeId]
        {
            get
            {
                return _employees.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                _employees.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        // String indexer: returns the employee count for a gender
        // or changes the gender of matching employees.
        public string this[string gender]
        {
            get
            {
                return _employees.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
            }
            set
            {
                foreach (Employee employee in _employees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine("Before changing the gender of all male employees to female");
            Console.WriteLine();

            Console.WriteLine("Total employees with Gender = Male: " + company["Male"]);
            Console.WriteLine();

            Console.WriteLine("Total employees with Gender = Female: " + company["Female"]);
            Console.WriteLine();

            // Change the gender of all male employees to female.
            company["Male"] = "Female";

            Console.WriteLine("After changing the gender of all male employees to female");
            Console.WriteLine();

            Console.WriteLine("Total employees with Gender = Male: " + company["Male"]);
            Console.WriteLine();

            Console.WriteLine("Total employees with Gender = Female: " + company["Female"]);

            Console.ReadLine();
        }
    }
}
