//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
  
    public class AllInOnePrinter
    {
        public void PrintRecipeonConsole(Recipe recipe)
        {                               
                Console.WriteLine(recipe.GetTextToPrint());
        }
// Se divide en dos métodos ya que la clase solo se ocupa de imprimir. Se aplica el principio SRP y Expert ya que la clase solo imprime, puede decidir si a un archivo o a la consola.
        public void PrintRecipeonFile(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}