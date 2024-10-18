using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5
using System;

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
        Console.WriteLine("digite a idade do candidato ");
       
       int idade = Convert.ToInt32(Console.ReadLine());
       
       
       if (idade >= 18) {
         
         Console.WriteLine("enviar um E-mail:  parabéns você passou para a próxima fase");
        } 
       
  
     else  {
         
         Console.WriteLine("Envie um E-mail: Obrigado, você não passou para próxima fase");
         
       }
       
       Console.WriteLine("a idade do participante é: " + idade);
       
     }
   }
 }
