using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp96
{
    class Numbers : Strings
    {
        
        public Numbers (string str ) : base()
        {
            try
            {
                int n = int.Parse(str);
                this.str = new StringBuilder(n.ToString());
            }
            catch(Exception exp)
            {
                
              Console.WriteLine("не число");
                this.str = new StringBuilder(" ");
            }
        }

        public override int CountLenght()
        {
            return str.Length;
        }

        public override void editing(string s)
        {
            char[] arr = s.ToCharArray();
            bool flag = false;

            for (int i = 0; i < arr.Length;i++)
            {
                if (char.IsLetter(arr[i]))
                {
                    throw new Exception("буква");
                }
                else
                {
                    flag = true;
                }

                  
            }

            if (flag)
           this.str.Append(s);
        }


        public void Upp2x()
        {
           
            int n = 2 * int.Parse(this.str.ToString());
            this.str.Remove(0,str.Length) ;
            this.str.Append(n.ToString());
        }

        public override string ToString()
        {
           
            return this.str.ToString();
        }
    }
}
