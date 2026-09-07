using BibliotecaMatriz;
using System;
using System.Runtime.CompilerServices;

class Ex08
{
  static void Main()
  {
    //matriz que representa a cidade é 500x500
    int[,] cidade = new int[500, 500];
    // ler um n (2<=n<=500000)

    Console.Write("Número de Raios registrados: ");
    int n = int.Parse(Console.ReadLine()!);


    // preecnher a cidade
    for (int i = 0; i < cidade.GetLength(0); i++)
      for (int j = 0; j < cidade.GetLength(1); j++)
        cidade[i, j] = 0;

    // Matriz.mostrarMatriz(cidade);

    // ler as coordenadas dos raios
    Console.WriteLine("Coordenadas dos raios: [x y]");
    for (int i = 0; i < n; i++)
    {
      string input = Console.ReadLine()!;
      int indexEspaco = input.IndexOf(' '); //retorna o indice de onde esta o primeiro espaço
      int x = int.Parse(input.AsSpan(0, indexEspaco)); //retorna o valor - convertido em int - do começo (posição 0) até o primeiro indice que possui um espaço ' '
      int y = int.Parse(input.AsSpan(indexEspaco + 1)); //retorna o valor a partir do indice do primeiro espaço armazenado em indexEspaco até o fim da string - convertido em int.

      cidade[x, y]++;
    }

    // Matriz.mostrarMatriz(cidade);

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