﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class Person
    {

        ////Γενικά ορίζουμε τα fields private και για κάθε field ορίζω ένα propertie ώστε να αλλάζω την τιμή του field.
        ////Αν κάνω τα fields public επηρεάζω το Encapsulation
        ////Fields
        //string _ssn;
        //string _passportData;
        //string _driverLicenseNumber;

        //string _firstName = "Test1";

        ////Properites
        //public bool HasProperDocuments
        //{
        //    get
        //    {
        //        return _ssn.Length > 0 && _passportData.Length > 0 && _driverLicenseNumber.Length > 0;
        //    }
        //}

        //public string FirstName
        //{
        //    get 
        //    {
        //        return _firstName;
            
        //    }
        //    set 
        //    { 
        //        if (value.Length < 1)
        //        {
        //            Console.WriteLine("Input is not accepted");
        //            return;
        //        }
        //        _firstName = value;
        //    }
        //}


        //public void Sleep()
        //{
        //    Console.WriteLine("Sleep");

        //}

        private string firstName {  get; set; }
        private string lastName { get; set; }
        private int age { get; set; }
        private int eyeColor { get; set; }

        public Person(string firstName, string lastName, int age, int eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;

        }


    }
}
