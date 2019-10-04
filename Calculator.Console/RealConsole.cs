namespace Calculator.Console
{
    internal class RealConsole : IConsole
    {
        public string GetDisplay()
        {
            throw new System.NotImplementedException();
        }

        public void WriteLine(string line)
        {
            System.Console.WriteLine(line);
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}