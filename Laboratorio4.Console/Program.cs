using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.PieceMoves;
using Laboratorio4.Data;
using Laboratorio4.Infraestructura;
using Laboratorio4.Infraestructure.Logger;
using Laboratorio4.Infraestructure.PieceMovesSerializer;
using System;
using System.IO;

namespace Laboratorio4
{
    public  class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Chess Game Starting...");

            var logger = new FileLogger();

            var engine = new GameEngine(
                logger,
                new FileChessSource(),
                new JsonChessSerializer(),
                new ChessPieceMovesFactory(logger));

            engine.Move();

            if (engine.Moving == true)
            {
                System.Console.WriteLine($"Moving : {engine.Moving}");
            }
            else
            {
                System.Console.WriteLine("No moves.");
            }
        }
    }
}
