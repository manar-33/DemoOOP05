using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP05.Abstraction
{
    public abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Perimeter { get;  }
        public abstract decimal CalcArea();
    }
    class Rectangle : Rectbase
    {
        public override decimal Perimeter
        {

            get { return (Dim01 + Dim02) * 2; }
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    abstract class Rectbase : Shape
    { 
         public override decimal CalcArea() 
        {
            return Dim02 * Dim01;
        }
    
        
    }
    class Square : Rectbase
    {
        public Square(decimal Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        public override decimal Perimeter => Dim01 * 4;
       
    }
    class Circle : Shape
    {
        public Circle( decimal Redius)
        {
            Dim02 = Dim01 = Redius;
        }
        public override decimal Perimeter => 3.14M * Dim02 * 2;

        public override decimal CalcArea()
        {
            return 3.14M * Dim02 * Dim02;
        }
    }
}
