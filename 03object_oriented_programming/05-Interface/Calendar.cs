using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._05_Interface
{
    class Calendar:ISync
    {
        string title;
        DateTime date;
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public Calendar(string title,DateTime date)
        {
            Title = title;
            Date = date;
        }
        public string Sync()
        {
            return string.Format("CA|{0}|{1}<end> ", Title, Date);
        }
    }
}
