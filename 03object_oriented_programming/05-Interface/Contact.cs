using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._05_Interface
{
    class Contact:ISync
    {
        string name;
        string phone;
        public string Name { get; set; }
        public string Phone { get; set; }
        public Contact(string name,string phone)
        {
            Name = name;
            Phone = phone;
        }
        public string Sync()
        {
            return string.Format("CO|{0}|{1}<end>", Name, Phone);
        }
    }
}
