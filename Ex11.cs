using System;
using BibliotecaMatriz;

class Ex11
{
  static void verificarMaiorTesouro(int diagPrincipal, int diagSecundaria)
  {
    if (diagPrincipal > diagSecundaria)
    {
      Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
    }
    else if (diagSecundaria > diagPrincipal)
    {
      Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
    }
    else
    {
      Console.WriteLine("O tesouro das diagonais são iguais, escolha qualquer rota!.");
    }
  }

  static void Main()
  {
    Console.WriteLine("Insira a ordem da matriz NxN: ");
    int n = int.Parse(Console.ReadLine()!);

    int[,] mapa = new int[n, n];

    Matriz.gerarMatriz(mapa);

    Matriz.mostrarMatriz(mapa); //c

    //somar diagonal principal e secundaria
    int somaDiagPrincipal = 0;
    int somaDiagSecundaria = 0;

    somaDiagPrincipal = Matriz.somarDiagonalPrincipal(mapa);

    somaDiagSecundaria = Matriz.somarDiagonalSecundaria(mapa);

    Console.WriteLine("Soma da Diagonal Principal: " + somaDiagPrincipal);
    Console.WriteLine("Soma da Diagonal Secundaria: " + somaDiagSecundaria);

    verificarMaiorTesouro(somaDiagPrincipal, somaDiagSecundaria);
  }
}