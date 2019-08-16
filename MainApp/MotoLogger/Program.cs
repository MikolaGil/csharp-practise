using MotoLogger.Api;
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
            Logger.Log.Info("Application start.");

            CRUD crud = new CRUD();
            Motorcycle motorcycle = new Motorcycle();
            string[] motoArray = Motorcycle.FillArray();

            crud.Read(1, motoArray);
            crud.Update(0, motoArray, "Ducati");
            crud.Create("Minsk", motoArray);
            crud.Delete(0, motoArray);

            Console.ReadLine();
        }
    }
}
