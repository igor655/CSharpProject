using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using enum datatype
// https://metanit.com/sharp/tutorial/2.12.php

namespace CSharpProject
{
    internal class Program
    {
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        static void Main(string[] args)
        {
           const  DayTime now = DayTime.Evening;

            Console.WriteLine(now);
        }
    }
}
