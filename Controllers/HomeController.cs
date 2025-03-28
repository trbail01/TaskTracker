using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;

namespace TaskTracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private static List<ToDo> _tasks = new();

    [HttpGet]
    public IActionResult Index() => View(_tasks);

    [HttpGet]
    public IActionResult Add() => View();

    [HttpPost]
    public IActionResult Add(ToDo task) {
        if (ModelState.IsValid) {
            task.Id = _tasks.Count + 1;
            _tasks.Add(task);
            return RedirectToAction("Index");
        }

        return View(task);
    }

    [HttpPost]
    public IActionResult Filter(string[] filter) {
        ViewBag.Filters = string.Join(",", filter);
        return
            View("Index", _tasks.Where(t => filter.Contains(t.Type.ToString())).ToList());
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
