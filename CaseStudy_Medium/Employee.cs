using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class Employee
{
    int id, age;
    string name;
    double salary;
    int Retrieve;
    public Dictionary<int, Tuple<int, string, double>> EmpDetails = new Dictionary<int, Tuple<int, string, double>>();
    public Employee()
    {
    }

    public Employee(int id, int age, string name, double salary)
    {
        this.id = id;
        this.age = age;
        this.name = name;
        this.salary = salary;
    }

    public void TakeEmployeeDetailsFromUser()
    {
        for (; ; )
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
            if (!EmpDetails.ContainsKey(id))
            {
                EmpDetails.Add(id, new Tuple<int, string, double>(age, name, salary));
            }
            Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                continue;
            else
                break;
        }
        Console.WriteLine("Please enter the employee ID");
        Retrieve = Convert.ToInt32(Console.ReadLine());
        foreach (var Entity in EmpDetails)
        {
            if (Entity.Key == Retrieve)
            {
                Console.WriteLine("Employee ID={0}\nAge= {1}\nName = {2}\nSalary={3}", Entity.Key, Entity.Value.Item1, Entity.Value.Item2, Entity.Value.Item3);
            }
        }
    }

    public override string ToString()
    {
        return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
    }
    public int Id { get => id; set => id = value; }
    public int Age { get => age; set => age = value; }
    public string Name { get => name; set => name = value; }
    public double Salary { get => salary; set => salary = value; }
}