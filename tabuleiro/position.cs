namespace Teste.tabuleiro
{
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        override public string ToString()
        {
            return Row + ", " + Column;
        }


    }
}