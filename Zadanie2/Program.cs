using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{

    public class Detal
    {

        int var1;
        string var2;
        string var3;
        public void Func1() { }
        public void Func2() { }
        public virtual void Func3() { }

    }

    public class Mechanism : Detal
    {
        int var1;
        string var2;
        string var3;
        public void Func1() { }
        public void Func2() { }
        public override void Func3() { }

    }
    public class Izdelie : Mechanism
    {
        int var1;
        string var2;
        string var3;
        public void Func1() { }
        public void Func2() { }
        public void Func3() { }

    }
    public class Uzel : Izdelie
    {
        int var1;
        string var2;
        string var3;
        public void Func1() { }
        public void Func2() { }
        public void Func3() { }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}