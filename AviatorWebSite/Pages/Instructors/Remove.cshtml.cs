using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Instructors
{
    public class RemoveModel : PageModel
    {
        private readonly AccessDbContext _db;
        [BindProperty]
        public Instructor Instructor { get; set; }

        public RemoveModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Instructor = _db.Instructors.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var instructorFromDb = _db.Instructors.Find(Instructor.Id);
            if (instructorFromDb != null)
            {
                _db.Instructors.Remove(instructorFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Instructor data removed successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
