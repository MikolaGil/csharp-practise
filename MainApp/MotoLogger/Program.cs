using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();

            Logger.Log.Info("Test!");
            Logger.Log.Error("Error!");
        }
    }
}
