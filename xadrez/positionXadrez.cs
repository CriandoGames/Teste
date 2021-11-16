using Teste.tabuleiro;

namespace Teste.xadrez
{
    public class PositionXadrez
    {
        public int row { get; set; }
        public char column { get; set; }

        public PositionXadrez(char column, int row)
        {
            this.column = column;
            this.row = row;
        }

        public override string ToString()
        {
            return "" + column + row;
        }


        public Position toPosition()
        {
            return new Position(8 - row, column - 'a');
        } 
    }
}