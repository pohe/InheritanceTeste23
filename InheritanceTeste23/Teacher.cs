using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeste23
{
    public class Teacher : Employee
    {
        private List<Lecture> _lectures;

		private string _subject;


		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}

        public Teacher(int id, string name, string mobile, string subject):base(id, name, mobile)
        {
            _lectures = new List<Lecture>();
            _subject = subject;
        }

        public void AddLecture(Lecture lecture)
        {
            _lectures.Add(lecture);
        }
        public override int CalculateSalary()
        {
            if (_subject == "SWD")
                return base.CalculateSalary() * 2;
            return _baseSalary;
        }

        public override int CalculatePension()
        {
            return 10000;
        }
        public override string ToString()
        {
            //return base.ToString() + $" subject {_subject}";
            return $"Id {_id}  Name { Name} Mobile {Mobile} Subject {_subject}";
        }
    }
}
