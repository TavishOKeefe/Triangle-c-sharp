using System;
using System.Collections.Generic;

namespace Triangle {

  public class Program
  {

    static void Main()
    {

      Console.WriteLine("Enter a number to represent the length of one side of a triangle: ");
      string lengthSideOne = Console.ReadLine();
      int inputSideOne = int.Parse(lengthSideOne);
      Console.WriteLine("Side one = {0}", inputSideOne);

      Console.WriteLine("Enter a number to represent side two of a triangle: ");
      string lengthSideTwo = Console.ReadLine();
      int inputSideTwo = int.Parse(lengthSideTwo);
      Console.WriteLine("Side two = {0}", inputSideTwo);

      Console.WriteLine("Enter a number to represent side three of a triangle: ");
      string lengthSideThree = Console.ReadLine();
      int inputSideThree = int.Parse(lengthSideThree);
      Console.WriteLine("Side three = {0}", inputSideThree);

      Triangle triangle = new Triangle(inputSideOne, inputSideTwo, inputSideThree);

      string message = triangle.CheckType();
      Console.WriteLine(message);
    }
  }
}
