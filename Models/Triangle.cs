using System;

namespace Triangle {

  class Triangle
  {
    private int SideOne;
    private int SideTwo;
    private int SideThree;

    public Triangle (int sideOne, int sideTwo, int sideThree)
    {
      this.SideOne = sideOne;
      this.SideTwo = sideTwo;
      this.SideThree = sideThree;
    }

    public string CheckType()
    {
      if ((SideOne + SideTwo < SideThree) || (SideOne + SideThree < SideTwo) || (SideThree + SideTwo < SideOne))
      {
        string x = "This is not a triangle.";
        return x;
      }
      else if (SideOne == SideTwo && SideTwo == SideThree && SideOne == SideThree)
      {
       string y = "This is an equilateral triangle.";
        return y;
      } else if (SideOne == SideTwo || SideTwo == SideThree || SideOne == SideThree)
      {
        string z = "This is an isosceles triangle";
        return z;
      } else
      {
        string t = "This is a scalene triangle";
        return t;
      }
    }
  }
}
