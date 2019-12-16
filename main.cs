using System;

class MainClass {
  public static void Main (string[] args) {
    Quadrado Q = new Quadrado();

    Console.WriteLine ("Informe o lado A: ");
    Q.setLadoA(double.Parse (Console.ReadLine()));
    

    Console.WriteLine ("Informe o lado B: ");
    Q.setLadoB(double.Parse (Console.ReadLine()));

    Console.WriteLine ("Informe o lado C: ");
    Q.setLadoC(double.Parse (Console.ReadLine()));

    Console.WriteLine ("Informe o lado D: ");
    Q.setLadoD(double.Parse (Console.ReadLine()));

  }
}