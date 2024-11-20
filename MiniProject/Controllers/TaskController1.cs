using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject.model;

namespace MiniProject.Controllers
{
    public class TaskController1 : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (MiniClassRoomContext _context = new MiniClassRoomContext())
            {
                return View(await _context.DoingTasks.ToListAsync());
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DoingTask data)
        {
            using (MiniClassRoomContext _con = new MiniClassRoomContext())
            {
                await _con.DoingTasks.AddAsync(data);
                await _con.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
