
using Teste.pieces;
using Teste.tabuleiro;
using Teste.tabuleiro.errors;

Board tab = new Board(8, 8);


try
{

    tab.putPiece(new Tower(Color.branca, tab), new Position(1, 4));
    tab.putPiece(new Tower(Color.branca, tab), new Position(1, 3));
    tab.putPiece(new king(Color.branca, tab), new Position(2, 4));


    Screen.showBoard(tab);
}
catch (BoardException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();

