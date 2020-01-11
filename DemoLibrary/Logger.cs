namespace DemoLibrary
{
    public class Logger : ILogger
    {
        public void Log(string strValue)
        {
            System.Console.WriteLine($"Log:  {strValue}");
        }
    }
}