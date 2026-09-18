using System;
using BibliotecaMatriz;

class Ex09
{
  static int[] CalcularTropas(int[,] matriz)
  {
    int[] arrayTropas = new int[matriz.GetLength(0)];

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      int soma = 0;

      for (int j = 0; j < matriz.GetLength(1); j++)
        soma += matriz[i, j];


      arrayTropas[i] = soma;
    }

    return arrayTropas;
  }

  static void Main()
  {
    Console.WriteLine("Insira a quantidade de Regiões: [Linhas]");
    int l = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira a quantidade de Cidades: [Colunas]");
    int c = int.Parse(Console.ReadLine()!);

    int[,] matriz = new int[l, c];

    Matriz.gerarMatriz(matriz);

    Matriz.mostrarMatriz(matriz);

    int[] somaTropas = CalcularTropas(matriz);

    for (int i = 0; i < somaTropas.GetLength(0); i++)
      Console.WriteLine($"Região {i + 1}: {somaTropas[i]} tropas");

  }
}