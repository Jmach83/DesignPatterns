using Interfaces.Writers;

namespace Writer.Simulation
{
    class Random
    {
        private readonly IWriter _writer;
        private readonly System.Random _random = new System.Random();

        public Random(IWriter writer)
        {
            _writer = writer;
        }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                string result = _random.NextDouble() <= 0.5 ? "Heads" : "Tails";
                _writer.Write(result);
            }
        }
    }
}
