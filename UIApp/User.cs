using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIApp
{
    class User
    {
        string firstName;
        string lastName;
        int age;
        

        public User(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {age}";
        }
    }
}
