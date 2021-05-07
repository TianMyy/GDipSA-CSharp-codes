using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._05_Interface
{
    class Test
    {
        static void Main()
        {
            List<ISync> syncs = new List<ISync>();
            syncs.Add(new Calendar("Study Group", new DateTime(2020, 6, 1, 7, 0, 0)));
            syncs.Add(new Email("Hello", "mary@gmail.com"));
            syncs.Add(new Contact("Mary", "90800001"));
            string total = "";
            foreach (ISync ele in syncs)
                total += ele.Sync();
            Console.WriteLine("syncData = {0}", total);
        }
    }
}
