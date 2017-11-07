using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace FindNthElement
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> list = new SingleLinkedList<string>();
            list.Add("Hello");
            list.Add("Brave");
            SingleLinkedList<string>.Node del = list.Add("New");
            list.Add("World");
            list.Insert("Oh");
            list.FindNthToLast(3);
        }
    }
}
