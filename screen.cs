namespace Teste.tabuleiro
{
    public class Screen
    {
        public static void showBoard(Board board)
        {
            Console.Clear();
            for (int i = 0; i < board.rows; i++)
            {
                for (int j = 0; j < board.columns; j++)
                {
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.piece(i, j).ToString() + " ");
                    }

                }
                System.Console.WriteLine();
            }

        }
    }
}