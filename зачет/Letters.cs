using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp96
{
    class Letters : Strings
    {
        public Letters (string str)  : base (str)
        {

        }

        public override int CountLenght()
        {
           return str.Length;
        }

        public override void editing(string s)
        {
            char[] arr = s.ToCharArray();
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsDigit(arr[i]))
                {
                    throw new Exception("число");                 
                }
                else
                {
                    flag = true;
                }
                
            }

            if (flag)
            this.str.Remove(0, str.Length);
            this.str.Append(s);
        }

        public void Reverse()
        {
           for(int i = str.Length; i < 0;i--)
            {
               
                str.Append(str[i]);
            }
        }
    }
}
