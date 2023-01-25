using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Main
    {
        public static double Balance { get; set; }
        public static int Chickens { get; set; }
        public static double pasze { get; set; }
        public static bool Fox(int Date)
        {
            var result = Date % 2;
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Sunday(int Date)
        {
            var result = Date % 7;
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Is30(int Date)
        {
            var result = Date % 30;
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
