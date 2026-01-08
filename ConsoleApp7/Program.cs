using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{
    class Program
    {
        static void Main(string[] args)
        {
            number1 N1 = new number1();
            Console.WriteLine(N1.sum());           //1+2=3
            Console.WriteLine(N1.sum(3, 4));       //3+4=7

            number1 N2 = new number1(5, 5);
            Console.WriteLine(N2.sum());           //5+5=10

            number2 N3 = new number2();
            Console.WriteLine(N3.sum());           //1+2+10=13

            number3 N4 = new number3();
            Console.WriteLine(N4.sum());           //1+2+20=23

            //polymorphism
            number1 N5 = new number2();
            Console.WriteLine(N5.sum());           //1+2+10=13

            number1 N6 = new number3();
            Console.WriteLine(N6.sum());           //1+2+20=23

            number5 N7 = new number5();
            Console.WriteLine(N7.sub());          //30-20=10

            number5 N8 = new number5();
            Console.WriteLine(N8.multiply());    //30*20*10=6000

            number7 N9 = new number7();
            N9.multiplybyPI();              //5*3.14=15.7
        }
    }
}
