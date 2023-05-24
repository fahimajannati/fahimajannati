using System;
using System.Collections.Generic;

class Employee {
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string department, double salary) {
        Name = name;
        Department = department;
        Salary = salary;
    }

    public void DisplayDetails() {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine();
    }
}

class PayrollManagement {
    private List<Employee> employees;

    public PayrollManagement() {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee) {
        employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee) {
        employees.Remove(employee);
    }

    public void DisplayEmployees() {
        Console.WriteLine("All Employees:");
        foreach (Employee employee in employees) {
            employee.DisplayDetails();
        }
    }

    public double CalculateTotalSalary() {
        double totalSalary = 0;
        foreach (Employee employee in employees) {
            totalSalary += employee.Salary;
        }
        return totalSalary;
    }
}

class Program {
    static void Main(string[] args) {
        PayrollManagement payrollManagement = new PayrollManagement();

        Employee employee1 = new Employee("John Doe", "HR", 5000.0);
        payrollManagement.AddEmployee(employee1);

        Employee employee2 = new Employee("Jane Smith", "Sales", 6000.0);
        payrollManagement.AddEmployee(employee2);

        Employee employee3 = new Employee("Mike Johnson", "IT", 7000.0);
        payrollManagement.AddEmployee(employee3);

        payrollManagement.DisplayEmployees();

        Console.WriteLine("Total Salary: $" + payrollManagement.CalculateTotalSalary());

        Console.WriteLine("Removing employee: " + employee2.Name);
        payrollManagement.RemoveEmployee(employee2);

        Console.WriteLine("Updated Employee List:");
        payrollManagement.DisplayEmployees();
    }
}
