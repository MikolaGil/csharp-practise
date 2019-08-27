using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLogger
{
    public class Motorcycle
    {
        public string[] arr = new string[3];
        
        public static string[] FillArray()
        {
            Logger.Log.Info($"Create {typeof(Motorcycle)} array");
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.arr[0] = "Honda";
            motorcycle.arr[1] = "Yamaha";
            motorcycle.arr[2] = "Suzuki";
            return motorcycle.arr;
        }
        
    }
}
