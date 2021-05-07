using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1026
{
    interface IAction
    {
        void Eat();
        void Sleep();
        void Play();
    }
    public class Person:IAction
    { 
        public void Eat()
        {
            Console.WriteLine("Implementation details is ignored");
        }
        public void Sleep()
        {
            Console.WriteLine("Implementation details is ignored");
        }
        public void Play()
        {
            Console.WriteLine("Implementation details is ignored");
        }
    }
    public class Ques2
    {
        static void Main()
        {
            Person p = new Person();
            p.Eat();
            p.Sleep();
            p.Play();
        }
    }
}
