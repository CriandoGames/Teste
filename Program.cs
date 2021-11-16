
using Teste.pieces;
using Teste.tabuleiro;
using Teste.tabuleiro.errors;
using Teste.xadrez;


try
{
    PlayXadrez p = new PlayXadrez();

    while(!p.isFinished)
    {
        try
        {
            Console.Clear();
            Screen.showBoard(p.board);

            Console.Write("Origem: ");
            Position origen = Screen.readPositionXadrez().toPosition();
             Console.Write("Destino: ");
            Position destino = Screen.readPositionXadrez().toPosition();

            p.play(origen, destino);
        }
        catch(BoardException e)
        {
            Console.WriteLine(e.Message);
        }
    }


}
catch (BoardException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();

