using System;
using System.Collections.Generic;
using System.Text;

namespace UnicastDelegate
{ 
        class Manager : Employee
        {
            private double _pa;
            private double _fa;
            private double _oa;
            private double _grossSalary;

            public double PA
            {
                get
                {
                    PA = 0.08 * Salary;
                    return _pa;
                }
                set
                {
                    _pa = value;
                }
            }
            public double FA
            {
                get
                {
                    FA = 0.13 * Salary;
                    return _fa;
                }
                set { _fa = value; }
            }
            public double OA
            {
                get
                {
                    OA = 0.03 * Salary;
                    return _oa;
                }
                set { _oa = value; }
            }
            public double Grosssalary
            {
                set { _grossSalary = value; }
                get
                {
                    Grosssalary = PA + FA + OA;
                    return _grossSalary;
                }
            }
            public void PrintDetails()
            {
                Console.WriteLine("Employee Id: " + EmpNo);
                Console.WriteLine("Employee Name: " + EmpName);
                Console.WriteLine("Employee Salary: " + Salary);
            }

            public override void CalculateSalary()
            {
                base.CalculateSalary();

            }

        }
}
