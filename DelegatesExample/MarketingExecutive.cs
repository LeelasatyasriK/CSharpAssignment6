using System;
using System.Collections.Generic;
using System.Text;

namespace UnicastDelegate
{
        class MarketingExecutive : Manager
        {
            private double _KilometerTravel;
            private double _tourallowances;
            private double _telephoneallowances;
            private double _GrossSalary;

            public double KT
            {
                get
                {
                    return _KilometerTravel;
                }
                set
                {
                    _KilometerTravel = value;
                }
            }
            public double TA
            {
                get
                {
                    return _tourallowances;
                }
                set { _tourallowances = _KilometerTravel * 5; }

            }
            public double TeA
            {
                get
                {
                    return _telephoneallowances;
                }
                set
                {
                    _telephoneallowances = value;
                }
            }
            public double Grossalary
            {
                set { _GrossSalary = value; }
                get
                {
                    Grosssalary = KT + TA + TeA;
                    return _GrossSalary;
                }
            }
            public new void PrintDetails()
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
