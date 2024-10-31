using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .AsNoTracking()
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    Id = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    MiddleName = e.MiddleName,
                    JobTitle = e.JobTitle,
                    Salary = e.Salary
                }).ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }

            return sb.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .AsNoTracking()
                .OrderBy(e => e.FirstName)
                .Select(e => new
                {
                    FirstName = e.FirstName,
                    Salary = e.Salary
                }).Where(e => e.Salary > 50000)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .AsNoTracking()
                .Where(ep => ep.Department.Name == "Research and Development")
                .Select(ep => new
                {
                    FirstName = ep.FirstName,
                    LastName = ep.LastName,
                    Salary = ep.Salary,
                })
                .OrderBy(ep => ep.Salary)
                .ThenByDescending(ep => ep.FirstName)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from Research and Development - ${employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder builder = new StringBuilder();

            Address address = new Address()
            {
                TownId = 4,
                AddressText = "Vitoshka 15"
            };

            Employee? employee = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            employee.Address = address;
            context.SaveChanges();

            string[] employeeAddresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address!.AddressText)
                .ToArray();

            return string.Join(Environment.NewLine, employeeAddresses);
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var employees = context.Employees
                .AsNoTracking()
                .Select(e => new
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    ManagerFirst = e.Manager!.FirstName,
                    ManagerLast = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                        .Where(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003)
                        .Select(p => new
                        {
                            ProjectName = p.Project.Name,
                            StartDate = p.Project.StartDate,
                            EndDate = p.Project.EndDate
                        })
                        .ToArray()
                })
                .Take(10)
                .ToArray();

            foreach (var employee in employees)
            {
                stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirst} {employee.ManagerLast}");
                if (employee.Projects.Count() > 0)
                {
                    foreach (var project in employee.Projects)
                    {
                        string endDate = project.EndDate.HasValue ? project.EndDate?.ToString("M/d/yyyy h:mm:ss tt")! : "not finished";
                        stringBuilder.AppendLine($"--{project.ProjectName} - {project.StartDate} - {endDate}");
                    }
                }
            }
            return stringBuilder.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses
                .AsNoTracking()
                .Select(a => new
                {
                    Text = a.AddressText,
                    Town = a.Town!.Name,
                    Count = a.Employees.Count()
                })
                .OrderByDescending(a => a.Count)
                .ThenBy(a => a.Town)
                .ThenBy(a => a.Text)
                .Take(10)
                .ToArray();

            foreach (var item in addresses)
            {
                sb.AppendLine($"{item.Text}, {item.Town} - {item.Count} employees");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Select(e => new { 
                    Id = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    JobTitle = e.JobTitle,
                    Projects = e.EmployeesProjects
                        .OrderBy(p => p.Project.Name)
                        .Select(p => p.Project.Name)
                })
                .First(e => e.Id == 147);

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            sb.AppendLine(string.Join(Environment.NewLine, employee.Projects));

            return sb.ToString().TrimEnd();
        }



        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(GetEmployee147(context));
        }
    }
}

