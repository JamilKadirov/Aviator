using AviatorWebSite.Data;
using AviatorWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AviatorWebSite.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly AccessDbContext _db;
        public IEnumerable<Instructor> InstructorList { get; set; }
        public IndexModel(AccessDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            InstructorList = _db.Instructors;
        }
    }
}
