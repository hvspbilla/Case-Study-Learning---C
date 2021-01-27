using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy_Medium_Q3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

        class EmployeePromotion
        {
            List<Employee> EmpDetailsInList = new List<Employee>();
            Dictionary<int, Employee> EmpDetails = new Dictionary<int, Employee>();
            public void AddData()
            {

                int choice = 1;
                while (choice == 1)
                {
                    Employee EmpClass = new Employee();
                    EmpClass.TakeEmployeeDetailsFromUser();
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                foreach (var Entity in EmpDetails)
                {
                    EmpDetailsInList.Add(Entity.Value);
                }
                if (choice == 0)
                { SortAndPrintEmployee(); }
                else
                    Console.WriteLine("Please enter correct choice.");

            }

            public void SortAndPrintEmployee()
            {
                EmpDetailsInList.Sort();
            Console.WriteLine("The sorted employee list");
                foreach (var Entity in EmpDetailsInList)
                {
                    Console.WriteLine(Entity);
                Console.WriteLine("............................");
                }
                FetchingSameName();
            }
            public void FetchingSameName()
            {
                Console.WriteLine("Please enter the employee name");
                string FetchingName = Console.ReadLine();
                foreach (var Entity in EmpDetailsInList)
                {
                    if (Entity.Name == FetchingName)
                    {
                        Console.WriteLine(Entity);
                    }
                }
            }
        }
    }


