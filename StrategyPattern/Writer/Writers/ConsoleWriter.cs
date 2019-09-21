using Interfaces.Writers;
using System;

namespace Writer.Writers
{
    class ConsoleWriter : IWriter
    {
        public void Write(string result)
        {
            Console.WriteLine(result);
        }
    }
}
