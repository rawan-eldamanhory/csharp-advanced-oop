using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{ 
    //adstraction
    public abstract class number4
    {
        public int num3 = 30;
        public int num4 = 20;

        //abstract method
        public abstract int sub();

        public virtual int multiply()
        {
            return num3 * num4;
        }

    }

    public class number5 : number4
    {
        int num5 = 10;

        public  override int sub()
        {
            return num3 - num4;
        }

        public override int multiply()
        {
           return num3 * num4 * num5;
        }
    }
}
