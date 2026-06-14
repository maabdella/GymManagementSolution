using GymManagement.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Controllers;

public class PlansController : Controller
{
    private readonly GymDbContext dbContext ;
    public PlansController()
    {
        dbContext = new GymDbContext();
    }

    // Index Action >> List all plans
    // Get baseurl/plans/index

    public async Task<IActionResult> Index()
    {
        var plans =await dbContext.Plans.ToListAsync();
        return View(plans);
    }


    // Details Action >> show details of 1 plan
    // Get baseurl/plans/details/10....

    public async Task<IActionResult> Details(int id) 
    {
        var plan = await dbContext.Plans.FindAsync(id);
        if (plan is null)
            return RedirectToAction(nameof(Index));
        else
            return View(plan);
        
    }
}   
