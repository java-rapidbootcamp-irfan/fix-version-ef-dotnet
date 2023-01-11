using fix_ef_donet.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace fix_ef_donet.Controllers
{
    public class AssetController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssetController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<AssetEntity> categories = _context.AssetEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            AssetEntity asset = _context.AssetEntities.Find(id);
            return View(asset);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("AssetCode, AssetName, PurchaseYear, JumlahAsset,  Description")] AssetEntity request)
        {
           
            _context.AssetEntities.Add(request);
          
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.AssetEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.AssetEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
           
            _context.AssetEntities.Remove(entity);
          
            _context.SaveChanges();
            return Redirect("GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, AssetCode, AssetName, PurchaseYear, JumlahAsset,  Description")] AssetEntity request)
        {
            
            _context.AssetEntities.Update(request);
            
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
