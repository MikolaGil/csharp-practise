using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoLogger.Api
{
    class CRUD
    {
        public void Read(int index, string[] array)
        {
            Logger.Log.Info($"Read {index} element of array");
            try
            {
                Console.WriteLine($"{index + 1} element is - {array[index]}");
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }
        }

        public void Update(int index, string[] arr, string newValue)
        {
            Logger.Log.Info($"Update {index + 1} element of array");

            try
            {
                arr[index] = newValue;
                Console.WriteLine($"Now {index + 1} is {arr[index]}");
            } catch(Exception ex)
            {
                Logger.Log.Fatal(ex);
            }

        }

        public void Create(string elem, string[] arr)
        {
            Logger.Log.Info($"Create new element of array");

            try
            {
                arr[arr.Length +1] = elem;
                Console.WriteLine($"Added element is {elem}");
            }
            catch (Exception ex)
            {
                Logger.Log.Fatal(ex);
            }
        }

        public void Delete(int index, string[] arr)
        {
            Logger.Log.Info($"Delete {index} element of array");

            try
            {
                string temp = arr[index];
                arr[index] = string.Empty;
                Console.WriteLine($"Deleted element is {temp}");
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }
        }
    }
}
