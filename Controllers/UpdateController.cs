using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using elib.Models;

namespace elib.Controllers;

public class UpdateController : Controller
{
  private readonly ILogger<UpdateController> _logger;

  public UpdateController(ILogger<UpdateController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
