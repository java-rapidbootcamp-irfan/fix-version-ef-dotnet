using fix_ef_donet.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace fix_ef_donet.Controllers
{
    public class NinjaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public NinjaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<NinjaEntity> categories = _context.NinjaEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            NinjaEntity ninja = _context.NinjaEntities.Find(id);
            return View(ninja);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("NinjaName,NinjaGender, Ninjacolor, NinjaPower")] NinjaEntity request)
        {
           
            _context.NinjaEntities.Add(request);
         
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.NinjaEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.NinjaEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            // remove from entity
            _context.NinjaEntities.Remove(entity);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,NinjaName,NinjaGender, Ninjacolor, NinjaPower")] NinjaEntity request)
        {
            // update entity
            _context.NinjaEntities.Update(request);
            // commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
