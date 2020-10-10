using System;
namespace MagicalShow_3rd_HandIn
{
    public class Staff : Person
    {
        // instance variables
        private int salary;

        // constructor
        public Staff(int salary, string name, string password) : base(name, password)
        {
            this.salary = salary;
        }

        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return this.Name + " (ID: "+this.Id+") gets paid " + Salary + " DKK/month";
        }
    }
}
