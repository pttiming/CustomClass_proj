using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> l1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l2 = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> l3 = l1 - l2;
            //1 is the Common Item from l2 that exists in l1, so it will be removed.
            foreach (int i in l3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
