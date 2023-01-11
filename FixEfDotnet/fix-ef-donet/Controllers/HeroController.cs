using fix_ef_donet.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace fix_ef_donet.Controllers
{
    public class HeroController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllHero()
        {
            IEnumerable<HeroEntity> hero = _context.HeroEntities.ToList();
            return View(hero);
        }

        [HttpGet]
        public IActionResult DetailHero(int? id)
        {
            HeroEntity hero = _context.HeroEntities.Find(id);
            return View(hero);
        }

        [HttpGet]
        public IActionResult AddHero()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveHero([Bind("HeroName, HeroRole, HeroPower")] HeroEntity request)
        {
           
            _context.HeroEntities.Add(request);
          
            _context.SaveChanges();

            return Redirect("GetAllHero");
        }

        [HttpGet]
        public IActionResult EditHero(int? id)
        {
            var hero = _context.HeroEntities.Find(id);
            return View(hero);
        }

        [HttpGet]
        public IActionResult DeleteHero(int id)
        {
            var hero = _context.HeroEntities.Find(id);
            if (hero == null)
            {
                return Redirect("GetAllHero");
            }
           
            _context.HeroEntities.Remove(hero);
           
            _context.SaveChanges();
            return RedirectToAction("GetAllHero");
        }

        [HttpPost]
        public IActionResult UpdateHero([Bind("Id, HeroName, HeroRole, HeroPower")] HeroEntity request)
        {
           
            _context.HeroEntities.Update(request);
           
            _context.SaveChanges();
            return Redirect("GetAllHero");
        }
    }
}
