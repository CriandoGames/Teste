using Teste.tabuleiro;

namespace Teste.pieces
{
    public class king : Piece
    {
        public king(Color cor, Board tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "K";
        }

    }
}