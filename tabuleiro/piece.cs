namespace Teste.tabuleiro
{
    public class Piece
    {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int amountOfMovements { get; protected set; }
        public Board board { get; protected set; }
        public Piece(Position position, Color color, int amountOfMovements, Board board)
        {
            this.position = position;
            this.color = color;
            this.amountOfMovements = 0;
            this.board = board;
        }

    }
}