// 2. Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o menor 
// valor da matriz.

using System;
using BibliotecaMatriz;

class Ex02
{
  static void Main()
  {
    Console.Write("Linhas: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Colunas: ");
    int m = int.Parse(Console.ReadLine()!);

    int[,] matriz = new int[n, m];

    Matriz.gerarMatriz(matriz);

    Matriz.mostrarMatriz(matriz);

    int menorValor = Matriz.buscarMenorValor(matriz);

    Console.WriteLine("Menor valor: " + menorValor);
    Console.ReadKey();
  }
}