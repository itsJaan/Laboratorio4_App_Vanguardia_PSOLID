using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Core.PieceMoves
{
    public class ChessPieceMovesFactory
    {
        private readonly ILogger _logger;

        public ChessPieceMovesFactory(ILogger logger)
        {
            _logger = logger;
        }

        public ChessPieceMove Create(ChessPiece piece)
        {
            try
            {
                return (ChessPieceMove)Activator.CreateInstance(Type.GetType($"Laboratorio4.Core.PieceMoves.{piece.type}Piece"),
                    new object[]
                    {
                        _logger
                    });
            }
            catch
            {
                return new UnknownPiece(_logger);
            }
        }
    }
}
