﻿//Felipe Ruiz
//Abstract Class
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
    //Create an abstract class called Vehicle

{
    public abstract class Vehicle
    {
    //The vehicle class shall have three string properties Year, Make, and Model
    //Set the defaults to something generic in the Vehicle class
    public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
    //Vehicle shall have an abstract method called DriveAbstract with no implementation
        public abstract void DriveAbstract(); // stubbed out method - meaning no implementation  
    //Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }




    }
}
