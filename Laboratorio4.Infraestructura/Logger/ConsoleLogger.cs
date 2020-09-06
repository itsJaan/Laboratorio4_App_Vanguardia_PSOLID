using Laboratorio4.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Infraestructure.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine($"[{DateTime.Now}] - {message}");
        }
    }
}
