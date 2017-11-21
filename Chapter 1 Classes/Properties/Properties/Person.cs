﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {

        public string Name { get; set; }
        //By declaring private set we cannot means its read only and we can't change it but only with a constructor
        public DateTime Birthdate { get; private set; }


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
       
        

        public int Age
        {

            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;

            }
        }


    }
}
