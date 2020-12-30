using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp96
{
    abstract class Strings
    {
        protected StringBuilder str;

        public Strings(string str)
        {
            this.str = new StringBuilder(str);
        }

        public Strings()
        {
            
        }

        public override string ToString()
        {
            return "Рядок " + " " + str;
        }

        public abstract int CountLenght();
        public abstract void editing(string s);

    }
}
