using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller
{
    private LabManagerContext _context;

    public ComputerController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        return View(_context.Computers);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Computer computer)
    {
        if(!ModelState.IsValid) 
        {
            return View(computer);
        }

        _context.Computers.Add(computer);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Show(int id)
    {
        Computer? computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound(); //return RedirectToAction("Index");
        }

        return View(computer);
    }
}