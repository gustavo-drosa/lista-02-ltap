using BibliotecaMatriz;
using System;
using System.Runtime.CompilerServices;

class Ex08
{
  static void Main()
  {
    //matriz que representa a cidade é 500x500
    int[,] cidade = new int[500, 500];

    Console.Write("Número de Raios registrados: ");
    int n = int.Parse(Console.ReadLine()!);

    // preencher a cidade
    Matriz.preencherMatrizZero(cidade);

    // ler as coordenadas dos raios
    Console.WriteLine("Coordenadas dos raios: [x y]");
    for (int i = 0; i < n; i++)
    {
      string[] input = Console.ReadLine()!.Split(' ');

      int x = int.Parse(input[0]);
      int y = int.Parse(input[1]);

      cidade[x, y]++;
    }

    //verificar se caiu 2 vezes no mesmo lugar
    int caiu = 0;

    for (int i = 0; i < cidade.GetLength(0); i++)
      for (int j = 0; j < cidade.GetLength(1); j++)
        if (cidade[i, j] > 1)
          caiu = 1;

    //output
    Console.WriteLine(caiu);
    Console.ReadKey();
  }
}