using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Static
{
    internal class Utility
    {
        public Utility(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X:{X}, Y: {Y}";
        }
        public static double CmToInch (double cm)
            { return cm/2.54; }
        static Utility()
        {
            //Used for Initalize Static Attributes
            pi = 3.14;
        }
        private static double pi;

        public static double PI
        {
            get { return pi; }
           
        }

    }
}
