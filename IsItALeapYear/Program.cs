using System;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Boolean IsItALeapYear(int year)
        {
            if(year%4==0)
            {
                if(year%100==0)
                {
                    if(year%400==0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
           return false;
        }
    }
}
