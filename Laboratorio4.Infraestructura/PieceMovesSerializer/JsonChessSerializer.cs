using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4.Infraestructure.PieceMovesSerializer
{
    public class JsonChessSerializer : IChessSerializer
    {
        public ChessPiece SerializeChessPiece(string chessPiecesJson)
        {
            return JsonConvert.DeserializeObject<ChessPiece>(chessPiecesJson, new StringEnumConverter());
        }
    }
}
