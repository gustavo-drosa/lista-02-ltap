using System;
using BibliotecaMatriz;
using System.Collections.Generic;


// Crie uma função que receba uma matriz N por M e conte quantos números iguais a X existem na matriz. X 
// deve ser informado pelo usuário (parâmetro da função). Retorne a quantas ocorrências de X existem na 
// matriz.
class Ex05
{
  static void Main()
  {
    Console.Write("Insira a quantidade de linhas: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Insira a quantidade de colunas: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Qual número deseja procurar na matriz? ");
    int numero = int.Parse(Console.ReadLine()!);

    int[,] matriz = new int[n, m];

    Matriz.gerarMatrizReduzida(matriz);

    int apareceu = 0;

    List<string> coordenadas = new List<string>();

    for (int i = 0; i < matriz.GetLength(0); i++)
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        if (matriz[i, j] == numero)
        {
          apareceu++;
          coordenadas.Add($"{i + 1},{j + 1}");
        }
      }

    Matriz.mostrarMatriz(matriz);
    Console.Write($"Número {numero} aparece {apareceu} vezes!\n");

    if (apareceu > 0)
    {
      Console.Write("Nas coordenadas: [");
      foreach (var x in coordenadas)
      {
        Console.Write($"({x})");
      }
      Console.WriteLine("]");
    }

    Console.ReadKey();
  }
}