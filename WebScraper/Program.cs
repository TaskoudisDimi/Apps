﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person = new Person();
            person.FirstName = "Test";

            Console.WriteLine(person.FirstName);

            person.FirstName = "";
            Console.WriteLine(person.FirstName);

        }
    }
}