using Nancy;
using Cds.Objects;

namespace Cds
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        var allCds = Cd.GetAll();
        return View["All_cds.cshtml", allCds];
      };
      Get["/add_cds"] = _ =>{
        return View["add_Cd.cshtml"];
      };

      Post["/all_cd"] = _ => {
        var newCd = new Cd(Request.Form["new-title"], Request.Form["new-artist"], Request.Form["new-price"]);
        var allCds = Cd.GetAll();
        return View["All_cds.cshtml", allCds];
      };
    }
  }
}
