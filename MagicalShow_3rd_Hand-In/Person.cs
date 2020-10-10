using System;
namespace MagicalShow_3rd_HandIn
{
    public abstract class Person
    {
        // instance variables
        private static int idCounter = 0;
        private int id;
        private string name;
        private string password;

        public Person(string name, string password)
        {
            idCounter++;
            this.id = idCounter;
            this.name = name;
            this.password = CeasarEncryption.Encrypt(password, 12);
        }

        // Name property
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        // Password property
        public string Password
        {
            set { this.password = CeasarEncryption.Encrypt(value, 12); }
        }

        public int Id { get => id; }

        public Boolean TryLogin(string Name, string Password)
        {
            if (Name == this.Name && CeasarEncryption.Encrypt(Password, 12) == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
