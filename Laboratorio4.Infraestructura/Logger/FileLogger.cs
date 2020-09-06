using Laboratorio4.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laboratorio4.Infraestructure.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using var stream = File.AppendText("log.txt");
            stream.WriteLine($"[{DateTime.Now}] - {message}");
            stream.Flush();
        }
    }
}
