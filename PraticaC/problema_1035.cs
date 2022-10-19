using System;
public class problema_1035{
  public static void Main(string[] args){
    string a = Console.ReadLine();
    string[] b = a.Split();
    int c = b.Select(int.Parse).ToArray();
    Console.WriteLine(a);
  }
}