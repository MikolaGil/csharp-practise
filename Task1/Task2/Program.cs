using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //object value
            arrayList.Add(45);  //true, boxing
            arrayList.Add(true);  //true, boxing
            arrayList.Add("Hello!");  //true, boxing
            arrayList.Add(23.45);  //true, boxing
        }
    }
}
