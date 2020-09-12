using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using Laboratorio4.Core.Pieces;
using System;
using Xunit;

namespace Laboratorio4.Test
{
    public class BishopPieceMoveTest
    {
       private readonly ILogger _logger;

        [Fact]
        public void TestBishopPieceMoveSuccecs()
        {
            //Arange
            var piece = new ChessPiece();
            piece.type = ChessPieceType.Bishop;
            piece.from = "g1";
            piece.to = "f3";

            var logic = new BishopPiece(_logger);

            //Act
            var response = logic.move(piece);

            //Assert
            Assert.True(response);
        }

        [Fact]
        public void TestBishopPieceMoveFails()
        {
            //Arange
            var piece = new ChessPiece();
            piece.type = ChessPieceType.Bishop;
            piece.from = "g1";
            piece.to = "f5";

            var logic = new BishopPiece(_logger);

            //Act
            var response = logic.move(piece);

            //Assert
            Assert.False(response);
        }
    }
}
