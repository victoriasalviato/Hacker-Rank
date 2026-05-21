using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public int Age { get; set; }
}

public class EmployeeManagement
{
    private List<Employee> employees;

    public EmployeeManagement(List<Employee> employees)
    {
        this.employees = employees;
    }

    public Dictionary<string, int> AverageAgeForEachCompany()
    {
        return employees
            .GroupBy(e => e.Company)
            .OrderBy(g => g.Key)
            .ToDictionary(
                g => g.Key,
                g => (int)Math.Round(g.Average(e => e.Age))
            );
    }

    public Dictionary<string, int> CountOfEmployeesForEachCompany()
    {
        return employees
            .GroupBy(e => e.Company)
            .OrderBy(g => g.Key)
            .ToDictionary(
                g => g.Key,
                g => g.Count()
            );
    }

    public Dictionary<string, Employee> OldestAgeForEachCompany()
    {
        return employees
            .GroupBy(e => e.Company)
            .OrderBy(g => g.Key)
            .ToDictionary(
                g => g.Key,
                g => g.OrderByDescending(e => e.Age).First()
            );
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());
        var employeeList = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Trim().Split(' ');
            employeeList.Add(new Employee
            {
                FirstName = parts[0],
                LastName = parts[1],
                Company = parts[2],
                Age = int.Parse(parts[3])
            });
        }

        var mgmt = new EmployeeManagement(employeeList);

        var avgAge = mgmt.AverageAgeForEachCompany();
        foreach (var kvp in avgAge)
            Console.WriteLine($"The average age for company {kvp.Key} is {kvp.Value}");

        var count = mgmt.CountOfEmployeesForEachCompany();
        foreach (var kvp in count)
            Console.WriteLine($"The count of employees for company {kvp.Key} is {kvp.Value}");

        var oldest = mgmt.OldestAgeForEachCompany();
        foreach (var kvp in oldest)
            Console.WriteLine($"The oldest employee of company {kvp.Key} is {kvp.Value.FirstName} {kvp.Value.LastName} having age {kvp.Value.Age}");
    }
}
