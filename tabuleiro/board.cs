using Teste.tabuleiro.errors;

namespace Teste.tabuleiro
{
    public class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;


        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            pieces = new Piece[rows, columns];
        }

        public Piece piece(int row, int column)
        {
            return pieces[row, column];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.Row, pos.Column];
        }

        public bool existPiece(Position pos)
        {
            isValidPosition(pos);
            return piece(pos) != null;
        }
        
        

        public void putPiece(Piece p, Position pos)
        {
            if (existPiece(pos))
            {
                throw new BoardException("There is already a piece in this position!");
            }
            pieces[pos.Row, pos.Column] = p;
            p.position = pos;
        }


        public bool isValidPosition(Position pos)
        {
            if (pos.Row < 0 || pos.Row >= rows || pos.Column < 0 || pos.Column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validPosition(Position pos)
        {
            if (!isValidPosition(pos))
            {
                throw new BoardException("Position not valid!");
            }
        }
    }
}