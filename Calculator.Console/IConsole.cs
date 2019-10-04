namespace Calculator.Console
{
    public interface IConsole
    {
        string GetDisplay();
        void WriteLine(string line);
        string ReadLine();
    }
}