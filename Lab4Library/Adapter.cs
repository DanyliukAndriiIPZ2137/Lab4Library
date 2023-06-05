namespace Lab4Library
{
    public interface ILogger
    {
        void Log(string message);
        void Error(string message);
        void Warn(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    public class FileWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class FileWriterAdapter : ILogger
    {
        private readonly FileWriter fileWriter;

        public FileWriterAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }


        public void Error(string message)
        {
            this.fileWriter.WriteLine(message);
        }

        public void Log(string message)
        {
            this.fileWriter.Write(message);
        }

        public void Warn(string message)
        {
            this.fileWriter.WriteLine(message);
        }
    }

}