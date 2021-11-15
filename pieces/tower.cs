using Teste.tabuleiro;

namespace Teste.pieces
{
    public class Tower : Piece
    {
        public Tower(Color cor, Board tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}