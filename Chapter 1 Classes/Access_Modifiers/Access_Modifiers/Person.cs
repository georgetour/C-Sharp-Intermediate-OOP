using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Person
    {

        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate; //if the _birthdate was birthdate then we should write this.birthdate so we could understand where we refer
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }




    }
}
