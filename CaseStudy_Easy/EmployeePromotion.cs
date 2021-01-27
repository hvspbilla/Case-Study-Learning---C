using System;
using System.Collections.Generic;

namespace CaseStudy_Easy
{
    class EmployeePromotion
    {
        public void Display()
        {
            string data;
            var EmpName = new List<string>();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            for (; ;)
            {
                data = Console.ReadLine();
                if (data == " ")
                    break;
                EmpName.Add(data);
            }
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            string ToFind = Console.ReadLine();
            int Position = EmpName.IndexOf(ToFind);
            if (Position == -1)
                Console.WriteLine("Employee doesn't have eligibity for promotion.");
            else
                Console.WriteLine("" + ToFind + " is at the position" + " " + Position + " for promotion.");
            Console.WriteLine("The current size of the collection is " + EmpName.Capacity);
            EmpName.TrimExcess();
            Console.WriteLine("The size after removing the extra space is " + EmpName.Capacity);
            Console.WriteLine("Promoted Employee List:");
            var SortedPromotionsList = new List<string>();
            SortedPromotionsList = EmpName;
            SortedPromotionsList.Sort();
            foreach (string name in SortedPromotionsList)
                Console.WriteLine(name);
        }
    }
}