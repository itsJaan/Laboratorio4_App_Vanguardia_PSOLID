using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using Laboratorio4.Core.PieceMoves;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Core.Pieces
{
    public class RookPiece : ChessPieceMove
    {
        public RookPiece(ILogger logger)
           : base(logger)
        {

        }

        public override bool move(ChessPiece piece)
        {
            // T g1-f3 
            // Rook  x = 4  y = 0 ->  x = 4 y = 4 

            Logger.Log("Moving Rook...");
            Logger.Log("Validating Movement.");
            bool isMove = false;
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int actualX = Array.IndexOf(abc, piece.from.Substring(0));
            int actualY = Int32.Parse(piece.from.Substring(1));
            int destinyX = Array.IndexOf(abc, piece.to.Substring(0));
            int destinyY = Array.IndexOf(abc, piece.to.Substring(0));


            if (destinyX < 8 && destinyX >= 0 && destinyY < 8 && destinyY >= 0)
            {
                if ((actualX - destinyX) < 8 && (actualX - destinyX) >= -8)
                {
                    if ((actualY - destinyY) == 0)
                    {
                        isMove = true;
                    }
                }
                else if ((actualY - destinyY) < 8 && (actualY - destinyY) >= -8)
                {
                    if ((actualX - destinyX) == 0)
                    {
                        isMove = true;
                    }
                }

            }
            else
            {
                Logger.Log("Movement Out of Range.");

            }

            return isMove;

        }
    }
}
