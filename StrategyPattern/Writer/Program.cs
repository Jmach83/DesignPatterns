using Interfaces.Writers;
using System;
using Writer.Writers;

namespace Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter consoleWriter = new ConsoleWriter();
            Simulation.Random consoleSimulation = new Simulation.Random(consoleWriter);
            Console.WriteLine("*********************************************");
            Console.WriteLine("Console writer");
            Console.WriteLine("*********************************************");
            consoleSimulation.Run();

            Console.WriteLine("");

            IWriter fileWriter = new FileWriter("/Path/text.txt");
            Simulation.Random fileSimulation = new Simulation.Random(fileWriter);
            Console.WriteLine("*********************************************");
            Console.WriteLine("File writer");
            Console.WriteLine("*********************************************");
            fileSimulation.Run();

            Console.ReadLine();
        }
    }
}
