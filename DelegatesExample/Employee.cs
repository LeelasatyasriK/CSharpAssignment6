using System;
using System.Collections.Generic;
using System.Text;

namespace UnicastDelegate
{
		public class Employee
		{
			private int _empNo;
			private string _empName;
			private double _salary;
			private double _hra;
			private double _ta;
			private double _da;
			public double PF;
			public double TDS;
			public double NetSalary;
			private double _grossSalary;
			public int EmpNo
			{
				get
				{
					return _empNo;
				}
				set
				{
					_empNo = value;
				}
			}

			public string EmpName
			{
				get
				{
					return _empName;
				}
				set
				{
					_empName = value;
				}
			}
			public double Salary
			{
				get
				{

					return _salary;
				}
				set
				{
					_salary = value;
				}
			}

			public double HRA
			{
				get
				{
					if (_salary < 5000)
					{
						_hra = 0.1 * _salary;

					}
					else if (_salary < 10000)
					{
						_hra = 0.15 * _salary;
					}
					else if (_salary < 15000)
					{
						_hra = 0.2 * _salary;
					}
					else if (_salary < 20000)
					{
						_hra = 0.25 * _salary;
					}
					else if (_salary >= 20000)
					{
						_hra = 0.3 * _salary;
					}
					return _hra;
				}
			}
			public double Ta
			{
				get
				{
					if (_salary < 5000)
					{
						_ta = 0.05 * _salary;

					}
					else if (_salary < 10000)
					{
						_ta = 0.1 * _salary;
					}
					else if (_salary < 15000)
					{
						_ta = 0.15 * _salary;
					}
					else if (_salary < 20000)
					{
						_ta = 0.2 * _salary;
					}
					else if (_salary >= 20000)
					{
						_ta = 0.25 * _salary;
					}
					return _ta;
				}
			}
			public double Da
			{
				get
				{
					if (_salary < 5000)
					{
						_da = 0.15 * _salary;

					}
					else if (_salary < 10000)
					{
						_da = 0.2 * _salary;
					}
					else if (_salary < 15000)
					{
						_da = 0.25 * _salary;
					}
					else if (_salary < 20000)
					{
						_da = 0.3 * _salary;
					}
					else if (_salary >= 20000)
					{
						_da = 0.35 * _salary;
					}
					return _da;
				}
			}
			public double GrossSalary
			{
				get
				{
					return _grossSalary = _salary + _hra + _ta + _da;

				}
			}
			public virtual void CalculateSalary()
			{
				PF = 0.1 * GrossSalary;
				Console.WriteLine("PF:{0}", PF);
				TDS = 0.18 * GrossSalary;
				Console.WriteLine("TDS:{0}", TDS);
				NetSalary = GrossSalary - (PF + TDS);
				Console.WriteLine("NET Salary:{0}", NetSalary);


			}


		}
}
