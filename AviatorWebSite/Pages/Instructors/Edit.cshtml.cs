using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Instructors
{
    public class EditModel : PageModel
    {
        private readonly AccessDbContext _db;
        [BindProperty]
        public Instructor Instructor { get; set; }

        public EditModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Instructor = _db.Instructors.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Instructors.Update(Instructor);
                await _db.SaveChangesAsync();
                TempData["success"] = "Instructor data updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
