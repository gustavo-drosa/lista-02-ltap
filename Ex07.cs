using System;
using BibliotecaMatriz;

class Ex07
{
  static void Main()
  {
    Console.WriteLine("Linhas da Matriz A: ");
    int linhasA = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Colunas da Matriz A: ");
    int colunasA = int.Parse(Console.ReadLine()!);


    Console.WriteLine("Linhas da Matriz B: ");
    int linhasB = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Colunas da Matriz B: ");
    int colunasB = int.Parse(Console.ReadLine()!);

    int[,] matrizA = new int[linhasA, colunasA];
    int[,] matrizB = new int[linhasB, colunasB];

    Matriz.gerarMatriz(matrizA);
    Matriz.gerarMatriz(matrizB);

    Console.WriteLine("Matriz A -------------------");
    Matriz.mostrarMatriz(matrizA);
    Console.WriteLine("\nMatriz B -------------------");
    Matriz.mostrarMatriz(matrizB);

    //checar se é da mesma ordem
    if (matrizA.GetLength(0) == matrizB.GetLength(0) && matrizA.GetLength(1) == matrizB.GetLength(1))
    {
      Console.WriteLine("\nA + B -------------------");
      Matriz.somarMatrizes(matrizA, matrizB);
    }
    else
    {
      Console.WriteLine("\nMatrizes A e B não são de mesma ordem! Impossível somar.");
    }


    Console.ReadKey();
  }
}