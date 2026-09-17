using System;
using BibliotecaMatriz;

class Ex11
{
  static void Main()
  {
    Console.WriteLine("Insira a ordem da matriz NxN: ");
    int n = int.Parse(Console.ReadLine()!);

    int[,] mapa = new int[n, n]; //a

    Matriz.gerarMatriz(mapa); //b

    Matriz.mostrarMatriz(mapa); //c

    //somar diagonal principal e secundaria
    int somaDiagPrincipal = 0;
    int somaDiagSecundaria = 0;

    for (int i = 0; i < mapa.GetLength(0); i++)
      somaDiagPrincipal += mapa[i, i];

    for (int i = 0; i < mapa.GetLength(0); i++)
      for (int j = mapa.GetLength(1) - 1; j >= 0; j--)
      {
        somaDiagSecundaria += mapa[i, j];
        i++;
      }

    Console.WriteLine("Soma da Diagonal Principal: " + somaDiagPrincipal);
    Console.WriteLine("Soma da Diagonal Secundaria: " + somaDiagSecundaria);

    if (somaDiagPrincipal > somaDiagSecundaria)
    {
      Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
    }
    else if (somaDiagSecundaria > somaDiagPrincipal)
    {
      Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
    }
    else
    {
      Console.WriteLine("O tesouro das diagonais são iguais, escolha qualquer rota!.");
    }

  }
}