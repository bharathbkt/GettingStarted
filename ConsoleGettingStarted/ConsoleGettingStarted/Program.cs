using System;

namespace ConsoleGettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Loading application data..");
            GettingStarted.Data.GetData obj = new GettingStarted.Data.GetData();

            obj.LoadDataToSimulateDataFromDB();
            Console.WriteLine("Selected data for 1");
            var v = obj.SimulateGetFromDB(1);
            Console.WriteLine(v.ToString());
            Console.ReadKey();
        }
    }
}
