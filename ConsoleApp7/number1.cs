using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{
    class number1
    {
        private int num1;
        private int num2;

        //encapsluation
        public void setNum1(int v1)
        {
            this.num1 = v1;
        }
        public int getNum1()
        {
            return this.num1;
        }
        public void setNum2(int v2)
        {
            this.num2 = v2;
        }
        public int getNum2()
        {
            return this.num2;
        }

        //default constructor
        public number1()
        {
            this.setNum1(1);
            this.setNum2(2);
        }

        //parameted constructor
        public number1(int x , int y)
        {
            this.setNum1(x);
            this.setNum2(y);
        }

        public virtual int sum()
        {
            return this.getNum1() + this.getNum2();
        }

        //overload method
        public int sum (int d , int f)
        {
            return d + f;
        }


    }
}
