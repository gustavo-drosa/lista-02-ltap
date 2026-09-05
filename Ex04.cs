//  Escrever um programa  que gere uma matriz de N Linhas x N Colunas  e apresente sua diagonal secundária.

using System;
using BibliotecaMatriz;

class Ex04
{

  static void Main()
  {
    Console.Write("Insira um valor para Linhas e Colunas: ");
    int n = int.Parse(Console.ReadLine()!);


    int[,] matriz = new int[n, n];
    Matriz.gerarMatriz(matriz);

    Matriz.mostrarMatriz(matriz);

    Console.WriteLine("===========================");

    Matriz.mostrarDiagonalSecundaria(matriz);

    Console.ReadKey();
  }
}