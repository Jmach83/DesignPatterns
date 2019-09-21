using Interfaces.Writers;
using System;

namespace Writer.Writers
{
    class FileWriter : IWriter
    {
        private readonly string _path;

        public FileWriter(string path)
        {
            _path = path;
        }
        public void Write(string result)
        {
            Console.WriteLine("Writing " + result + " to " + _path);
        }
    }
}
