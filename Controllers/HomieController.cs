
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Homie.Controllers
{
  public class HomieController : Controller
  {
    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
