﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "John";
            var person = Person.Parse("John");
            person.Introduce("Test");
        }
    }
}
