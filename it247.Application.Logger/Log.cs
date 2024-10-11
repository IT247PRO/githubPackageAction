namespace it247.Application.Logger
{
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }

        public void Log(Exception exception)
        {
            Console.WriteLine(exception.Message.ToString());
        }
    }
}
