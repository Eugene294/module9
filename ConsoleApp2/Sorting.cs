using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Sorting
    {
        public string[] names;
        public delegate void SortDel(string[] names, int a);
        public event SortDel? Notify;


        public Sorting(string[] names) 
        {
            this.names = names;
        }
        public void Sort(string[] names, int a)
        {
            Notify?.Invoke(names,a);
        }
    }
}
