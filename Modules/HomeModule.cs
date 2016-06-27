using Nancy;
using Triangle.Objects;



namespace Triangle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/triangle_info"] = _ => {
        TriangleVariables myTriangleVariables = new TriangleVariables
        {
          Side1=Request.Query["side1"],
          Side2=Request.Query["side2"],
          Side3=Request.Query["side3"]
        };
        return View["triangle.cshtml", myTriangleVariables];
      };
    }
  }
}
