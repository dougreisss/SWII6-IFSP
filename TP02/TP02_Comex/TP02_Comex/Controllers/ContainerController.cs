using Microsoft.AspNetCore.Mvc;
using TP02_Comex.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP02_Comex.Repository;

public class ContainerController : Controller
{
    private readonly ContainerRepository _containerRepository;
    private readonly BlRepository _blRepository;

    public ContainerController(ContainerRepository containerRepository, BlRepository blRepository)
    {
        _containerRepository = containerRepository;
        _blRepository = blRepository;
    }

    public IActionResult Index()
    {
        var containers = _containerRepository.GetAll();
        return View(containers);
    }

    public IActionResult Create()
    {
        PopulateBLsDropDownList();
        return View();
    }

    [HttpPost]
    public IActionResult Create(Container container)
    {
        var bl = _blRepository.GetById(container.Bl?.IdBL ?? 0);

        if (bl == null)
        {
            ModelState.AddModelError("Bl.IdBL", "A valid BL must be selected.");
        }

        if (ModelState.IsValid)
        {
            _containerRepository.Add(container);
            return RedirectToAction(nameof(Index));
        }

        PopulateBLsDropDownList(container.Bl?.IdBL);
        return View(container);
    }

    public IActionResult Edit(int id)
    {
        var container = _containerRepository.GetById(id);
        if (container == null) return NotFound();

        PopulateBLsDropDownList(container.Bl?.IdBL);
        return View(container);
    }

    [HttpPost]
    public IActionResult Edit(Container container)
    {
        var bl = _blRepository.GetById(container.Bl?.IdBL ?? 0);
        if (bl == null)
        {
            ModelState.AddModelError("Bl.IdBL", "A valid BL must be selected.");
        }

        if (ModelState.IsValid)
        {
            _containerRepository.Update(container);
            return RedirectToAction(nameof(Index));
        }

        PopulateBLsDropDownList(container.Bl?.IdBL);
        return View(container);
    }

    public IActionResult Delete(int id)
    {
        var container = _containerRepository.GetById(id);
        if (container == null) return NotFound();

        return View(container);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _containerRepository.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var container = _containerRepository.GetById(id);
        if (container == null) return NotFound();

        return View(container);
    }

    private void PopulateBLsDropDownList(object selectedBL = null)
    {
        var bls = _blRepository.GetAll();
        ViewBag.BLs = new SelectList(bls, "IdBL", "Numero", selectedBL);
    }
}
