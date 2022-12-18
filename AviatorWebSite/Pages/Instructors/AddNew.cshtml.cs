using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Instructors
{
    public class AddNewModel : PageModel
    {
        private readonly AccessDbContext _db;
        [BindProperty]
        public Instructor Instructor { get; set; }

        public AddNewModel(AccessDbContext db)
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
                await _db.Instructors.AddAsync(Instructor);
                await _db.SaveChangesAsync();
                TempData["success"] = "Instructor's added successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
