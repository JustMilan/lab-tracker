using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab_tracker.Models;
using Microsoft.EntityFrameworkCore;
using lab_tracker.Data;
using lab_tracker.Models.domain;

namespace lab_tracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly lab_trackerContext _context;

    public HomeController(ILogger<HomeController> logger, lab_trackerContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        Matrix matrix = new Matrix()
        {
            Students = _context.Student.ToList(),
            Assignments = _context.Assignment.ToList(),
            AssignmentStudentStatuses = _context.AssignmentStudentStatus.ToList()
        };
        return View(matrix);
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

