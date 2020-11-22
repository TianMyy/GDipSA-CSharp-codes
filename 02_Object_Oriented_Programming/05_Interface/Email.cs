using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._05_Interface
{
    class Email:ISync
    {
        string content;
        string recipient;
        public string Content { get; set; }
        public string Recipient { get; set; }
        public Email(string cotent,string recipient)
        {
            Content = content;
            Recipient = recipient;
        }
        public string Sync()
        {
            return string.Format("EM|{0}|{1}<end> ", Content, Recipient);
        }
    }
}
