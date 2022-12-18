using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Fleet
{
    public class CreateModel : PageModel
    {
        private readonly AccessDbContext _db;
        [BindProperty]
        public Aircraft AirplaneCard { get; set; }

        public CreateModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Fleet.AddAsync(AirplaneCard);
                await _db.SaveChangesAsync();
                TempData["success"] = "Airplane card created successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
