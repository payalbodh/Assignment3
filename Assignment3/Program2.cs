using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Program2
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(11);
            s.Push(12);
            s.Push(13);
            s.Push(14);
            s.Push(15);

            foreach (int i in s)
            {
                Console.WriteLine("Push Element in Array:" + i + ",");
            }
            s.Pop();
            s.Pop();
            foreach (int i in s)
            {
                Console.WriteLine("After Pop ,Element in Array:" + i + ",");
            }

        }
    }
}
