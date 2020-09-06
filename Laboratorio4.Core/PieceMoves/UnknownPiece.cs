using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Core.PieceMoves
{
    public class UnknownPiece : ChessPieceMove
    {
        public UnknownPiece(ILogger logger)
           : base(logger)
        {
        }
        public override bool move(ChessPiece piece)
        {
            Logger.Log("Unknown piece type");
            return false;
        }
    }
}
