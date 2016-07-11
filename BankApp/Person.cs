using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Person
    {
        private string Password;
        public readonly string SIN;

        public bool IsAuthenticated { get; private set; }
        public string Name { get; private set; }

        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            this.Password = SIN.Substring(0,3);
        }
        public void Login(string password)
        {            
            if (password == Password)
                this.IsAuthenticated = true;
        }
        public void Logout()
        {
            this.IsAuthenticated = false;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} \nAuthenticated? {1}", Name, IsAuthenticated);
        }


    }
}
