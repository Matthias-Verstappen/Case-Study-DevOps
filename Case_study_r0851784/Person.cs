using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study_r0851784
{
	public class Person
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public int Drinks { get; set; }

		public string PlayGroup { get; set; }

		public Person() { }

		public Person(int ID, string Name, string Email, int Drinks, string PlayGroup) {
			this.ID = ID;
			this.Name = Name;
			this.Email = Email;
			this.Drinks = Drinks;
			this.PlayGroup = PlayGroup;
		}

	}

	public class Leader : Person
	{
		public string Tasks { get; set; }

		public Leader() { }

		public Leader (int ID, string Name, string Email, int Drinks, string PlayGroup, string tasks) : base(ID, Name, Email, Drinks, PlayGroup)
		{
			Tasks = tasks;
		}
	}
}
