﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppHomework
{
    public class CalculatorApp
    {
        public static void Main(string[] a)
        {

        }
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Modular(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double Triangle(double num1, double num2)
        {
            double result = 0.5 * num1 * num2;
            return result;
        }
        public double Circle(double num1)
        {
            double result = 3.142 * (num1 * num1);
            return result;
        }
        public double Square(double num1, double num2)
        {
            double result = num1 * num1;
            return result;
        }
    }
}
