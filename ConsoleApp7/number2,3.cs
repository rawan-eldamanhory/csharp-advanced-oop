using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{

    //inheritance
    class number2 : number1
    {
        
        //override method
        public override int sum()
        {
            return this.getNum1() + this.getNum2() + 10;
        }

    }

    class number3 : number1
    {
        public override int sum()
        {
            return this.getNum1() + this.getNum2() + 20;
        }
    }
}
