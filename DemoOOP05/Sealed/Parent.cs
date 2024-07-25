using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoOOP05.Sealed
{
    internal class Parent
    {
        private  int  salary;

        public virtual int  Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }
    class Child : Parent
    {
        public override int Salary 
        { 
            get => base.Salary; 
            set => base.Salary = value<5000 ? 5000 :value; 
        }
        public sealed override void Print()
        {
            Console.WriteLine("I am Child");
        }
    }
    class GrandChild : Child
    {
        //public override void Print() //=> invalid
        //{
        //    Console.WriteLine("I am GrandChild");
        //}
       
    }
}
