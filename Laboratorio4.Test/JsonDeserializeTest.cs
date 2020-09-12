using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using Laboratorio4.Infraestructure.PieceMovesSerializer;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Laboratorio4.Test
{
    public class JsonDeserializeTest
    {
        private readonly IChessSerializer _chessSerializer;

        [Theory]
        [InlineData("{\r\n  \"name\": \"Bishop\",\r\n  \"go\": \"g1\",\r\n  \"to\": \"f3\"\r\n}\r\n")]
        public void DeserializeInvalid(string chessPiecesJson)
        {
    
            var response = _chessSerializer.SerializeChessPiece(chessPiecesJson);

            //Assert
            Assert.IsNotType<ChessPiece>(response);
        }
    }
}
