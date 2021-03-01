using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleList list = new DoubleList(5);
            list.Add(15);
            list.Add(10);
            list.Add(20);

            list.ShowFromEnd();

            list.ShowFromStart();

            list.SortDoubleListAscByValue();
            list.DeleteByValue(20);

            list.ShowFromStart();
        }
    }
}
