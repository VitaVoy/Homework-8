using System; // Виталий Войтов
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._1 // С помощью рефлексии выведите все свойства структуры DateTime.
{
    class Program
    {       


        static void Main(string[] args)
        {
            Type t = typeof(DateTime);
            foreach (var prop in t.GetProperties())
            Console.WriteLine(prop.Name);
            

            Console.ReadLine();

            

        }
    }
}
