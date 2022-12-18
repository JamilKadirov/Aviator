using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Fleet
{
    public class DeleteModel : PageModel
    {
        private readonly AccessDbContext _db;
        [BindProperty]
        public Aircraft AirplaneCard { get; set; }

        public DeleteModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            AirplaneCard = _db.Fleet.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var airplaneFromDb = _db.Fleet.Find(AirplaneCard.Id);
            if (airplaneFromDb != null)
            {
                _db.Fleet.Remove(airplaneFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Airplane card deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
