// See https://aka.ms/new-console-template for more information
 using System;
 using namespace Abstraindo_um_jogo_de_RPG.src

 namespace Abstraindo_um_jogo_de_RPG.src
 {

   class Program
   {
     
     static void Main(string[] args)
     {
        Hero arus = new Arus("Arus", 23, "knight");
        Wizard wizard = new wizard("Jenica", 23, "White Wizard");

        Console.WriteLine(Wizard.Atack(1));
        Console.WhiteLine(wizard.Atack(7));
     }    
 }



