using System;
using System.Linq;
public class treino{
  public static void Main(string[] args){
    Console.WriteLine("Digite uma número de 1 a 9 para saber um dia marcante para tecnologia.");
    int data = int.Parse(Console.ReadLine());
    switch(data){
      case 1: Console.WriteLine("É o dia do Programador 13/08/2002"); break;
      case 2: Console.WriteLine("É o Dia do Profissional de Tecnologia da Informação 19/10"); break;
      default: Console.WriteLine("Não sei."); break;
    }
  }
}