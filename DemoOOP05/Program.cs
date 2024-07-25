using DemoOOP05.Abstraction;
using DemoOOP05.Casting_Operator_Overloading;
using DemoOOP05.Operator_Overloading;
using DemoOOP05.Partial;
using DemoOOP05.Static;

namespace DemoOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int X = 10 + 20;
            //string Name = "Manar" + "Mahmoud";
            //Complex C01 = new Complex() {Real=3, Imag=4};
            //Console.WriteLine(C01);
            //Complex C02 = new Complex() { Real=7, Imag=5};
            //Console.WriteLine(C02);
            //Complex C03 = default;
            // C03 = C01 + C02;
            #region Binary operator
            //C03 = C02 - C01;
            //Console.WriteLine(C03); 
            #endregion
            #region Unary Operator
            //C03 = ++C01;// PreFix
            //C03 = C01++; // PostFix
            //Console.WriteLine(C03);
            //C03 = --C01;
            #endregion
            #region Relational operator
            //if (C01 > C02)
            //    Console.WriteLine("C01 > C02");
            //else if (C02 > C01)
            //    Console.WriteLine("C02 > C01");
            //else 
            //    Console.WriteLine("C02 = C01");
            #endregion
            #region Casting operator overloading
            //Complex C01 = new Complex() { Real =4 , Imag = 2};
            ////  int Y = (int)C01;//invalid
            //string Y = (string)C01;
            //User user = new User()
            //{
            //    Id = 1,
            //    FullName = "Manar Mahmoud",
            //    Email = "manar@gmail.com",
            //    Password = "password",
            //    SecurityStamp = Guid.NewGuid()
            //};
            //UserViewModel userViewModel = (UserViewModel)user;
            #endregion
            #region Abstraction
            //Rectangle rectangle = new Rectangle();
            //rectangle.Dim01= 10;
            //rectangle.Dim02= 20;
            //Console.WriteLine( rectangle.CalcArea());
            //decimal primeter = rectangle.Perimeter;
            //Console.WriteLine( primeter );
            #endregion
            #region Static
            //Utility utility = new Utility(10,20);
            //utility.X = 10;
            //utility.Y = 20;
            //Console.WriteLine( utility.ToString());
            //Utility.CmToInch(10); 
            #endregion
            #region Partial
            //Employee employee = new Employee() { Id =10,Name="manar",Salary=5000,Age=23};
            //employee.Print();
            #endregion
        }
    }
}
