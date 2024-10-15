using Microsoft.AspNetCore.Mvc;
using TP02_Comex.Models;
using System.Collections.Generic;

public class BlController : Controller
{
    private readonly BlRepository _repository;

    public BlController(BlRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var bls = _repository.GetAll();
        return View(bls);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Bl bl)
    {
        if (ModelState.IsValid)
        {
            _repository.AddBl(bl);
            return RedirectToAction(nameof(Index));
        }
        return View(bl);
    }

    public IActionResult Edit(int id)
    {
        var bl = _repository.GetById(id);
        if (bl == null) return NotFound();
        return View(bl);
    }

    [HttpPost]
    public IActionResult Edit(Bl bl)
    {
        if (ModelState.IsValid)
        {
            _repository.UpdateBl(bl);
            return RedirectToAction(nameof(Index));
        }
        return View(bl);
    }

    public IActionResult Delete(int id)
    {
        var bl = _repository.GetById(id);
        if (bl == null) return NotFound();
        return View(bl);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _repository.DeleteBl(id);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var bl = _repository.GetById(id);
        if (bl == null) return NotFound();
        return View(bl);
    }
}
