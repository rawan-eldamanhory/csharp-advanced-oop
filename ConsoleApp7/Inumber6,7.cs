using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{
    public static class mycostant
    {
        public const double PI = 3.14;

    }
    //interface
   public interface Inumber6
   {
      void multiplybyPI();
   }

    public class number7 : Inumber6
    {
        public double num8 = 5;

        public void multiplybyPI()
        {
            Console.WriteLine(num8*mycostant.PI);
        }
    }
}
