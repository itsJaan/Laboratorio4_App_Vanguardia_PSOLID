using Laboratorio4.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Core.Interfaces
{
    public interface IChessSerializer
    {
        ChessPiece SerializeChessPiece(string chessPiecesJson);
    }
}
