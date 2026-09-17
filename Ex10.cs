using System;
using System.Xml;

class Ex10
{
  static void Main()
  {
    int areaTotal = 0;
    int[,] mapa = new int[100, 100];

    for (int i = 0; i < mapa.GetLength(0); i++)
      for (int j = 0; j < mapa.GetLength(1); j++)
        mapa[i, j] = 0;

    Console.WriteLine("Total de redes: ");
    int redes = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Entre com as coordenadas [Xi Xf Yi Yf]: ");
    for (int i = 0; i < redes; i++)
    {
      string[] input = Console.ReadLine()!.Split(' ');

      int xi = int.Parse(input[0]);
      int xf = int.Parse(input[1]);
      int yi = int.Parse(input[2]);
      int yf = int.Parse(input[3]);

      for (int l = xi; l < xf; l++)
        for (int c = yi; c < yf; c++)
        {
          if (mapa[l, c] == 0)
          {
            mapa[l, c] = 1;
            areaTotal++;
          }
        }

    }

    Console.WriteLine("Área total das redes: " + areaTotal);
  }
}