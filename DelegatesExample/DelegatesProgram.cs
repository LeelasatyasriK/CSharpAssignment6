using System;

namespace UnicastDelegate
{
    public delegate void dele();
        class DelegatesProgram
        {
            static void Main(string[] args)
            {
                MarketingExecutive m = new MarketingExecutive();
                Console.WriteLine("Enter Employee Number: ");
                m.EmpNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                m.EmpName = Console.ReadLine();

                Console.Write("Enter Employee salary: ");
                m.Salary = int.Parse(Console.ReadLine());


                Manager m1 = new Manager();

               Console.WriteLine("Enter Employee Number: ");
               m1.EmpNo = int.Parse(Console.ReadLine());

              Console.Write("Enter Employee Name: ");
              m1.EmpName = Console.ReadLine();

               Console.Write("Enter Employee salary: ");
               m1.Salary = int.Parse(Console.ReadLine());
               dele del = new dele(m1.PrintDetails);
                 del += new dele(m.PrintDetails);
           
                Console.WriteLine("Enter Kilometers travelled");
                int n = Convert.ToInt32(Console.ReadLine());
                m.KT = n;
                m.TeA = 1000;
                m.CalculateSalary();
            }
        }
}
