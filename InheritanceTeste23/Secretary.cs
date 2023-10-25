using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeste23
{
    public class Secretary:Employee
    {
		private string _responsibility;

		public string Responsibility
		{
			get { return _responsibility; }
			set { _responsibility = value; }
		}

        public Secretary( int id, string name, string mobile, string responsibility) : base(id, name, mobile) 
        {
            _responsibility = responsibility;
        }


        public override string ToString()
        {
            return base.ToString() + $"_responsibility";
        }

        public override int CalculateSalary()
        {
            return base.CalculateSalary()*3;
        }
    }
}
