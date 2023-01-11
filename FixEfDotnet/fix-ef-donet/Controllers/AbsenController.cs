using fix_ef_donet.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace fix_ef_donet.Controllers
{
    public class AbsenController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AbsenController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<AbsenEntity> categories = _context.AbsenEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            AbsenEntity absen = _context.AbsenEntities.Find(id);
            return View(absen);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("AbsenName, Izin, Sakit, Absen, JumlahHadir  Description")] AbsenEntity request)
        {
           
            _context.AbsenEntities.Add(request);
           
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.AbsenEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.AbsenEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
           
            _context.AbsenEntities.Remove(entity);
          
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,AbsenName, Izin, Sakit, Absen, JumlahHadir  Description")] AbsenEntity request)
        {
            
            _context.AbsenEntities.Update(request);
           
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
