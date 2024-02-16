using System;
using System.Collections.Generic;
using System.Text;

namespace FirstMobileApp.Models
{
    partial class Calcualtor
    {
        //public int Num1 { get; set; }
        //public int Num2 { get; set; }
        public Calcualtor()
        {
            
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
