using Teste.pieces;
using Teste.tabuleiro;

namespace Teste.xadrez
{
    public class PlayXadrez
    {
        public Board board { get; private set; }
        private int turn;
        public bool isFinished { get; private set; }
        private Color currentPlayer;

        public PlayXadrez()
        {
            board = new Board(8, 8);
            turn = 1;
            isFinished = false;
            currentPlayer = Color.branca;
            putPieces();
        }

        private void putPieces()
        {

            board.putPiece(new Tower(Color.branca, board), new PositionXadrez('c', 1).toPosition());
            board.putPiece(new Tower(Color.branca, board), new PositionXadrez('c', 2).toPosition());
            board.putPiece(new Tower(Color.branca, board), new PositionXadrez('d', 2).toPosition());
            board.putPiece(new Tower(Color.branca, board), new PositionXadrez('e', 2).toPosition());
            board.putPiece(new king(Color.branca, board), new PositionXadrez('e', 1).toPosition());
            board.putPiece(new king(Color.branca, board), new PositionXadrez('d', 1).toPosition());


            board.putPiece(new Tower(Color.preta, board), new PositionXadrez('c', 7).toPosition());
            board.putPiece(new Tower(Color.preta, board), new PositionXadrez('c', 8).toPosition());
            board.putPiece(new Tower(Color.preta, board), new PositionXadrez('d', 7).toPosition());
            board.putPiece(new Tower(Color.preta, board), new PositionXadrez('e', 7).toPosition());
            board.putPiece(new king(Color.preta, board), new PositionXadrez('e', 8).toPosition());
            board.putPiece(new king(Color.preta, board), new PositionXadrez('d', 8).toPosition());


        }

        public void play(Position origen, Position destine)
        {
            Piece p = board.removePiece(origen)!;
            p.incrementAmountOfMovements();
            Piece? pieceRemoved = board.removePiece(destine)!;
            board.putPiece(p, destine);
        }

    }
}