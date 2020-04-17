using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
	public class Employee
	{
		public int id;
		public string name;
		public double salary;

		public Employee(int id, string name, double salary)
		{
			this.id = id;
			this.name = name;
			this.salary = salary;
		}

		public override string ToString()
		{
			return this.name;
		}
	}
}
