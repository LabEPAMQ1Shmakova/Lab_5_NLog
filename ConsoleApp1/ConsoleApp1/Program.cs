using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;

namespace ConsoleApp1
{

    [Dev("Юлия Шмакова", 010)]

    class Program
    {
        private static NLog log = new NLog();



        public static void GetAttribute(Type t)
        {
            DevAttribute MyAttribute =
             (DevAttribute)Attribute.GetCustomAttribute(t, typeof(DevAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("Атрибут не найден.");
            }
            else
            {
                Console.WriteLine("Разработчик: {0}", MyAttribute.Name);
                Console.WriteLine("Номер ID: {0}\n", MyAttribute.ID);
            }
        }
        static void Main(string[] args)
        {
            GetAttribute(typeof(Program));

            log.StartProgram();

            Console.WriteLine("Введите данные для Керосина. Объем в м3, вес в г.");
            Kerosene kerosene = new Kerosene(ParseVolume(), ParseWheight(), "Керосин");
            kerosene.Dencity();
            log.SuccessSolve("Керосин");

            Console.WriteLine("Введите данные для Автобензина. Объем в м3, вес в г.");
            Petrol Petrol = new Petrol(ParseVolume(), ParseWheight(), "Автобензин");

            Petrol.Dencity();

            log.SuccessSolve("Автобензин");

            Console.WriteLine("Введите данные для Дизельного топлива. Объем в м3, вес в г.");
            DieselFluel DieselFluel = new DieselFluel(ParseVolume(), ParseWheight(), "Дизельное топливо");

            DieselFluel.Dencity();

            log.SuccessSolve("Дизельное топливо");

            Console.Read();
            log.StopProgram();
        }
        static double ParseVolume()
        {
            Console.Write("Объем: ");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Error: вводим только числа!");
                log.ErrorParse();
                return ParseVolume();
            }
        }

        static double ParseWheight()
        {
            Console.Write("Вес: ");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Error: вводим только числа!");
                log.ErrorParse();
                return ParseWheight();

            }
        }

    
            

        }


    

}
