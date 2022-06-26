using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Assignment3
{
    public class Program3 : ICloneable
    {
        public int i;
        public int j;

        public Program3(int a, int b)
        {
            i = a;
            j = b;
        }

        public new string ToString()
        {
            return "(" + i + "," + j + ")";
        }

        public virtual object Cloning()
        {
            return new Program3(i, j);
        }
        object ICloneable.Clone()
        {
            return Cloning();
        }
    }

}



