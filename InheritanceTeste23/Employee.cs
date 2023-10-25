using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeste23
{
    public class Employee
    {

		protected const int _baseSalary = 25000;

		protected int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _mobile;

		public string Mobile
		{
			get { return _mobile; }
			set { _mobile = value; }
		}

        public Employee( int id, string name, string mobile)
        {
			_id = id;
			_name = name;
			_mobile = mobile;
        }


		public virtual int CalculateSalary()
		{
			return _baseSalary;
		}

        public override string ToString()
        {
            return $"ID  {_id } Name {_name} Mobile {_mobile}";
        }
    }
}
