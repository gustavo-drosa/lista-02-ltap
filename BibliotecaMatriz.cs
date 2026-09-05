using System;
using System.IO;

namespace BibliotecaMatriz
{
  public class Matriz
  {
    public static void lerMatriz(int[,] matriz)
    {
      int linhas = matriz.GetLength(0);
      int colunas = matriz.GetLength(1);
      for (int i = 0; i < linhas; i++)
      {
        for (int j = 0; j < colunas; j++)
        {
          Console.Write($"Elemento [{i},{j}]: ");
          matriz[i, j] = int.Parse(Console.ReadLine()!);
        }
      }
    }

    public static void mostrarMatriz(int[,] matriz)
    {
      int linhas = matriz.GetLength(0);
      int colunas = matriz.GetLength(1);
      for (int i = 0; i < linhas; i++)
      {
        for (int j = 0; j < colunas; j++)
        {
          Console.Write($"{matriz[i, j],3}| ");
        }
        Console.WriteLine();
      }
    }

    public static void gerarMatriz(int[,] matriz)
    {
      Random random = new Random();
      int linhas = matriz.GetLength(0);
      int colunas = matriz.GetLength(1);
      for (int i = 0; i < linhas; i++)
        for (int j = 0; j < colunas; j++)
          matriz[i, j] = random.Next(0, 100);
    }

    public static int buscarMaiorValor(int[,] matriz)
    {
      int maiorValor = matriz[0, 0];

      for (int i = 0; i < matriz.GetLength(0); i++)
        for (int j = 0; j < matriz.GetLength(1); j++)
          if (maiorValor < matriz[i, j])
            maiorValor = matriz[i, j];

      return maiorValor;
    }

    public static int buscarMenorValor(int[,] matriz)
    {
      int menorValor = matriz[0, 0];

      for (int i = 0; i < matriz.GetLength(0); i++)
        for (int j = 0; j < matriz.GetLength(1); j++)
          if (menorValor > matriz[i, j])
            menorValor = matriz[i, j];

      return menorValor;
    }

    public static void mostrarDiagonalPrincipal(int[,] matriz)
    {
      Console.WriteLine("Diagonal Principal: ");

      for (int i = 0; i < matriz.GetLength(0); i++)
        for (int j = 0; j < matriz.GetLength(1); j++)
          if (i == j)
            Console.WriteLine($"{matriz[i, j],3}|");
    }

    public static void mostrarDiagonalSecundaria(int[,] matriz)
    {
      Console.WriteLine("Diagonal Secundaria: ");

      for (int i = 0; i < matriz.GetLength(0); i++)
        for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
        {
          Console.WriteLine($"{matriz[i, j]}|");
          i++;
        }
    }
  }
}