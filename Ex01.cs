using System;
using BibliotecaMatriz;

// 1. Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o maior valor da matriz. 
class Ex01
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

    int maiorValor = Matriz.buscarMaiorValor(matriz);

    Console.WriteLine("Maior valor: " + maiorValor);
    Console.ReadKey();
  }
}
