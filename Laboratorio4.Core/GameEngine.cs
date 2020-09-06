using Laboratorio4.Core.Interfaces;
using Laboratorio4.Core.PieceMoves;
using System;

namespace Laboratorio4.Data
{
    public class GameEngine
    {
        private readonly ILogger _logger;
        private readonly IChessSource _chessSource;
        private readonly IChessSerializer _chessSerializer;
        private readonly ChessPieceMovesFactory _chessPieceMovesFactory;
        public bool Moving { get; set; }

        public GameEngine(ILogger logger,IChessSource chessSource,IChessSerializer chessSerializer,ChessPieceMovesFactory chessPieceMovesFactory)
        {
            _logger = logger;
            _chessSource = chessSource;
            _chessSerializer = chessSerializer;
            _chessPieceMovesFactory = chessPieceMovesFactory;
        }

        public void Move()
        {
            _logger.Log("Starting Game");
            _logger.Log("Loading Moves");

            var chessJson = _chessSource.getPieceMovesFromSource();
            var chessPiece = _chessSerializer.SerializeChessPiece(chessJson);
            var chessPieceMove = _chessPieceMovesFactory.Create(chessPiece);
            Moving = chessPieceMove.move(chessPiece);
            _logger.Log("Move completed.");
        }
    }
}
