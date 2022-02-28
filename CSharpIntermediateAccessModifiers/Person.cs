using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateAccessModifiers
{
    public class Person
    {
        private DateTime _birthdate; //first word is lower case

        public void SetBirthdate(DateTime birthDate)
        {
            _birthdate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
}
