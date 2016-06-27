namespace Triangle.Objects
{
  public class TriangleVariables
  {
    public int Side1{get;set;}
    public int Side2{get;set;}
    public int Side3{get;set;}
    public bool IsNotATriangle()
    {
      return (Side1+Side2<=Side3)||(Side3+Side2<=Side1)||(Side1+Side3<=Side2);
    }
    public bool IsEquilateral()
    {
      return (Side1==Side2)&&(Side2==Side3);
    }
    public bool IsIsoceles()
    {
      return (Side1==Side2)||(Side1==Side3)||(Side3==Side2);
    }
    public string TriangleDescription(){
      if (IsNotATriangle())
      {
        return "not a";
      }
      else if (IsEquilateral())
      {
        return "an equilateral";
      }
      else if (IsIsoceles())
      {
        return "an isoceles";
      }
      else
      {
        return "a scalene";
      }
    }
  }
}
