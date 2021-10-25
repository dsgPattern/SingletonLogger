using System.IO;

namespace Logger
{
    public class FileLogger : LoggerBase
    {
        private string _filePath = @"c:\temp\Filelogger.txt";

        public override void Log(string message)
        {
            using (var streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
