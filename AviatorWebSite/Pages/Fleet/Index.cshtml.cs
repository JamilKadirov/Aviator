using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Fleet
{
    public class IndexModel : PageModel
    {
        private readonly AccessDbContext _db;
        public IEnumerable<Aircraft> Airplanes { get; set; }
        public IndexModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Airplanes = _db.Fleet;
        }
    }
}
