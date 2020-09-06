using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Core.PieceMoves
{
    public abstract class ChessPieceMove
    {
        public ILogger Logger { get; set; }

        protected ChessPieceMove(ILogger logger)
        {
            Logger = logger;
        }

        public abstract bool move(ChessPiece piece);
    }
}
