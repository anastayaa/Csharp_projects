﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8RemotingEx1Object
{
    class CalculatorImpl : MarshalByRefObject, Calculator
    {
        public int Addition(int a, int b)
        {
            return a+b;
        }

        public int Incrementation(int valeur)
        {
            return valeur+1;
        }

        public int Multiplication(int a, int b)
        {
            return a*b;
        }
    }
}
