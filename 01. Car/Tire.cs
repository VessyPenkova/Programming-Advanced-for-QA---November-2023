﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufactureR
{
    public class Tire
    {
        //int year;
        double pressure;
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
