﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value > 0 ) 
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name,this.Age));

            //return stringBuilder.ToString();

            return $"Name: {Name}, Age: {Age}";
        }
    }
}
