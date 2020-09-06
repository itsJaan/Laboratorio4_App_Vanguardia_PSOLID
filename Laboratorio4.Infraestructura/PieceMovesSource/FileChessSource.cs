using Laboratorio4.Core.Interfaces;
using System;
using System.IO;

namespace Laboratorio4.Infraestructura
{
    public class FileChessSource : IChessSource
    {
        public string getPieceMovesFromSource()
        {
            return File.ReadAllText("C:\\Users\\ItsJaan\\Documents\\Docs Importantes\\CLSS\\2020\\TRI III 2020\\Apps Vanguardia\\Laboratorio4\\Laboratorio4.Console\\chess.json");
        }
    }
}
