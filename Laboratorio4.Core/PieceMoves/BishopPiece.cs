using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using Laboratorio4.Core.PieceMoves;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Laboratorio4.Core.Pieces
{
    public class BishopPiece : ChessPieceMove
    {
        public BishopPiece(ILogger logger)
            : base(logger)
        {

        }
       
        public override bool move(ChessPiece piece)
        {
            //C g1-f3 
            // Bishop  x = 6  y = 1 ->  x = 5 y = 3 
            //x {1 , 2 , -1 , -2 }
            //y {1 , 2 , -1 , -2 }
            Logger.Log("Moving Bishop...");
            Logger.Log("Validating Movement.");
            bool isMove = false;
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int actualX = Array.IndexOf(abc , piece.from.Substring(0)); 
            int actualY= Int32.Parse(piece.from.Substring(1));
            int destinyX= Array.IndexOf(abc, piece.to.Substring(0));
            int destinyY= Array.IndexOf(abc, piece.to.Substring(0));
            
            

            if (destinyX < 8 && destinyX>=0  && destinyY < 8 && destinyY >= 0 )
            {
                if((actualX-destinyX) == 1 || (actualX - destinyX) == -1)
                {
                    if((actualY - destinyY) == 2 || (actualY - destinyY) == -2)
                    {
                        isMove = true;
                    }

                }
                else if ((actualX - destinyX) == 2 || (actualX - destinyX) == -2)
                {
                    if ((actualY - destinyY) == 1 || (actualY - destinyY) == -1)
                    {
                        isMove = true;
                    }
                }
            }else 
            {
                Logger.Log("Movement Out of Range.");

            }
            return isMove;
        }
    }
}
