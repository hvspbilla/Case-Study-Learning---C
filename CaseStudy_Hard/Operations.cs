using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy_Hard
{
    class Operations
    {
        List<Employee> EmpDetailsInList = new List<Employee>();
        Dictionary<int, Employee> EmpDetails = new Dictionary<int, Employee>();
        public void AddingData()
        {
                Employee EmpClass = new Employee();
                EmpClass.TakeEmployeeDetailsFromUser();
            

            foreach (var Entity in EmpDetails)
            {
                EmpDetailsInList.Add(Entity.Value);
            }
            DisplayMenu();
        }
        public void ModifyDetails()
        {
            double UpdatedSalary;
            int UpdatedAge;
            string UpdatedName;
            Console.WriteLine("Please enter the employee ID");
            int FetchingId = Convert.ToInt32(Console.Read());
            foreach (var Entity in EmpDetailsInList)
            {
                if (Entity.Id == FetchingId)
                {
                    Console.WriteLine(Entity);
                }
            }
            Console.WriteLine("Please enter the updated employee details");
            Console.WriteLine("Please enter the employee name");
            UpdatedName = Console.ReadLine();
            foreach (var Entity in EmpDetailsInList)
            {
                if (Entity.Id == FetchingId)
                {
                    Entity.Name = UpdatedName;
                }
            }
            Console.WriteLine("Please enter the employee age");
            UpdatedAge = Convert.ToInt32(Console.ReadLine());
            foreach (var Entity in EmpDetailsInList)
            {
                if (Entity.Id == FetchingId)
                {
                    Entity.Age = UpdatedAge;
                }
            }
            Console.WriteLine("Please enter the employee Salary");
            UpdatedSalary = Convert.ToDouble(Console.ReadLine());
            foreach (var Entity in EmpDetailsInList)
            {
                if (Entity.Id == FetchingId)
                {
                    Entity.Salary = UpdatedSalary;
                }
            }
            DisplayMenu();
        }
        public void AllEmployees()
        {
            foreach (var Entity in EmpDetailsInList)
            {
                Console.WriteLine(Entity);
            }
            DisplayMenu();
        }
        public void FetchEmployee()
        {
            Console.WriteLine("Please enter the employee ID");
            int FetchersID = Convert.ToInt32(Console.ReadLine());
            foreach (var Entity in EmpDetailsInList)
            {
                if (Entity.Id == FetchersID)
                {
                    Console.WriteLine(Entity);
                }
            }
            DisplayMenu();
        }
        public void Exit()
        {
            System.Environment.Exit(0);
        }
        public void DisplayMenu()
        {
            int Choice;
            Console.WriteLine("Please enter the option\n1.Add an Employee\n2.Modify an employee detail\n3.Print all employee's details\n4.Print an employee detail\n5.Exit");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    AddingData();
                    break;
                case 2:
                    ModifyDetails();
                    break;
                case 3:
                    AllEmployees();
                    break;
                case 4:
                    FetchEmployee();
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Please Select Right Choice!");
                    break;
            }
        }
    }
}
