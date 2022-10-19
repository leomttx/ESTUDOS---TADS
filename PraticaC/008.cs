using System;

public class exe_008{
  public static void Main( string [] args){
    string a = Console.ReadLine();
    string[] b = a.Split(':');
    int h = int.Parse(b[0]);
    int m = int.Parse(b[1]);
    int s = int.Parse(b[2]);
    Console.WriteLine(h);
  }
}