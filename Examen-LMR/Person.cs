﻿using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string nation;
        protected string salary;
        public Person(string name, int age, string nation, string salary)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
            this.salary = salary;
        }
        public string GetName()
        {
            return name;
        }
        public string GetNation()
        {
            return nation;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetSalary()
        {
            return salary;
        }
    }
}
