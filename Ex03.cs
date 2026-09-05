// Escrever um programa  que gere uma matriz de N Linhas x N Colunas  e apresente sua diagonal principal. 
// Dica, limite sua matriz a uma ordem 100.

using System;
using BibliotecaMatriz;

class Ex03
{

  static void Main()
  {
    Console.Write("Insira um valor para Linhas e Colunas: ");
    int n = int.Parse(Console.ReadLine()!);


    int[,] matriz = new int[n, n];
    Matriz.gerarMatriz(matriz);

    Matriz.mostrarMatriz(matriz);

    Console.WriteLine("===========================");

    Matriz.mostrarDiagonalPrincipal(matriz);

    Console.ReadKey();
  }
}