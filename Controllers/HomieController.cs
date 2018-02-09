using LilHomie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LilHomie.Controllers
{
  public class HomieController : Controller
  {
    static Homie newHomie = new Homie(10, 10, 10);

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(newHomie);
    }
    [HttpPost("/sleep")]
    public ActionResult Sleep()
    {
      newHomie.SelectRest();
      return View();
    }
    // {
    //   newHomie.SelectRest();
    //   return View("Index", newHomie);
    // }
  }
}
