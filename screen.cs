using Teste.xadrez;

namespace Teste.tabuleiro
{
    public class Screen
    {
        public static void showBoard(Board board)
        {
            Console.Clear();
            for (int i = 0; i < board.rows; i++)
            {
                 System.Console.Write(8-i + " ");
                for (int j = 0; j < board.columns; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        showColorPiece(board.piece(i, j));
                        Console.Write(" ");
                       // Console.Write(board.piece(i, j).ToString() + " ");
                    }

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static PositionXadrez readPositionXadrez(){
            string s = Console.ReadLine()!;
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new PositionXadrez(column, row);
        }


        public static void showColorPiece(Piece piece)
        {
            if (piece.color == Color.branca)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux  = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}