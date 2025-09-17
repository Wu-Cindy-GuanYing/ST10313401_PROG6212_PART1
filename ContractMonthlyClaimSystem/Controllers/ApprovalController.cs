// Controllers/ApprovalController.cs
using Microsoft.AspNetCore.Mvc;

public class ApprovalController : Controller
{
    public IActionResult Index()
    {
        // Return view with dummy data
        return View();
    }

    public IActionResult Review(int id)
    {
        // Return view without processing
        return View();
    }

    [HttpPost]
    public IActionResult Approve(int id)
    {
        TempData["Message"] = "This is a demonstration only. No claim was actually approved.";
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Reject(int id, string reason)
    {
        TempData["Message"] = "This is a demonstration only. No claim was actually rejected.";
        return RedirectToAction("Index");
    }
}