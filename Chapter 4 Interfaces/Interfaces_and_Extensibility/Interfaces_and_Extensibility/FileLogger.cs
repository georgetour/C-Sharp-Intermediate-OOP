using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }


        public void LogError(string message)
        {
            Log(message, MessageType.ERROR.ToString());
        }

        public void LogInfo(string message)
        {
            Log(message, MessageType.INFO.ToString());
        }

        private void Log(string message, string messageType)
        {
            //The problem here is that the stream writer uses a file resouce which is not managed by the CLR
            //This means we have to dispose the resource when finished using that
            //With the using keyword the compiler automatically 
            //disposes the stream writer if something goes wrong
            using (var streaWriter = new StreamWriter(_path, true))
            {
                streaWriter.WriteLine(messageType +":" + message);
            }
        }

        private enum MessageType
        {
            ERROR ,INFO
        }
        


    }
}
