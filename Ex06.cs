using System;
using BibliotecaMatriz;
using System.Diagnostics;

class Ex06
{
  static char mostrarMenu()
  {

    Console.WriteLine("Opções:\n" +
    "(a) Somar matrizes\n" +
    "(b) Subtrair matriz A por B\n" +
    "(c) Adicionar uma constante as duas matrizes\n" +
    "(d) Imprimir Matrizes\n" +
    "(e) Limpar Tela\n" +
    "(f) Encerrar Sistema");
    char opcao = char.Parse(Console.ReadLine()!);

    opcao = char.ToLower(opcao);
    return opcao;

  }


  static void Main()
  {
    Console.WriteLine("Insira a quantidade de Linhas: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Insira a quantidade de Colunas: ");
    int m = int.Parse(Console.ReadLine()!);

    int[,] matrizA = new int[n, m];
    int[,] matrizB = new int[n, m];

    Matriz.gerarMatriz(matrizA); //trocar pra gerar matriz com valores reais
    Matriz.gerarMatriz(matrizB);

    bool rodarPrograma = true;

    while (rodarPrograma)
    {
      Console.WriteLine("\n\n");
      char opcao = mostrarMenu();

      switch (opcao)
      {
        case ('a'):
          Matriz.somarMatrizes(matrizA, matrizB);
          break;
        case ('b'):
          Matriz.subtrairMatrizes(matrizA, matrizB);
          break;
        case ('c'):
          Console.Write("Valor: ");
          int valor = int.Parse(Console.ReadLine()!);
          Matriz.adicionarConstante(valor, matrizA, matrizB);
          break;
        case ('d'):
          Console.WriteLine("\nMatriz A");
          Matriz.mostrarMatriz(matrizA);
          Console.WriteLine("\nMatriz B");
          Matriz.mostrarMatriz(matrizB);
          break;
        case ('e'):
          Console.Clear();
          break;
        case ('f'):
          rodarPrograma = false;
          break;
        default:
          mostrarMenu();
          break;
      }
    }

  }
}