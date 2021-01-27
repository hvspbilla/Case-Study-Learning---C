using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CaseStudy_Medium_Q4
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
            { OlderThanFetcher(); }
            else
                Console.WriteLine("Please enter correct choice.");

        }

        
        public void OlderThanFetcher()
        {
            int FetchersAge=0;
            Console.WriteLine("Please enter the employee ID");
            int FetchingId = Convert.ToInt32(Console.ReadLine());
            foreach (var OperationsEntity in EmpDetailsInList)
            {
                if (OperationsEntity.Id == FetchingId)
                {
                    FetchersAge = OperationsEntity.Age;
                }
            }
            var filteredResult = from Entity in EmpDetailsInList where Entity.Age > FetchersAge select Entity;
            foreach (var filteredEmployeeListObject in filteredResult)
            {
                Console.WriteLine(filteredEmployeeListObject);
            }
        }
    }
}

