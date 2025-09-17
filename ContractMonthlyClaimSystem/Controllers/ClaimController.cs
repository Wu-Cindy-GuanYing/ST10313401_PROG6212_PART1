// Controllers/ClaimController.cs
using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;

public class ClaimController : Controller
{
    public IActionResult Index()
    {
        // Return view with dummy data instead of real data
        return View();
    }

    public IActionResult Create() // Just return the view, no processing
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Claim model)// Instead of processing, just show a message or redirect since it's non-functional
    {
        TempData["Message"] = "This is a demonstration only. No claim was actually submitted.";
        return RedirectToAction("Index");
    }

    public IActionResult Details(int id) // Return view without fetching real data
    {
        return View();
    }

    public IActionResult UploadDocument()
    {
        return View();
    }

    [HttpPost]
    public IActionResult UploadDocument(IFormFile file) // Show message instead of actually uploading
    {
        TempData["Message"] = "This is a demonstration only. No file was actually uploaded.";
        return RedirectToAction("Index");
    }
}