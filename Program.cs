
using Teste.pieces;
using Teste.tabuleiro;

Board tab = new Board(8, 8);



tab.putPiece(new Tower(Color.branca, tab), new Position(0, 0));
tab.putPiece(new Tower(Color.branca, tab), new Position(1, 3));
tab.putPiece(new king(Color.branca, tab), new Position(2, 4));


Screen.showBoard(tab);

Console.ReadLine();

