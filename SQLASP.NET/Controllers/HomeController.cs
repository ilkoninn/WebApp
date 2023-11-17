
namespace SQLASP.NET.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();

            // Home Slider Section
            List<HomeSlider> sliderList = new List<HomeSlider>();
            sliderList = _context.HomeSliders.ToList();

            // Services Section
            List<Services> servicesList = new List<Services>();
            servicesList = _context.Services.ToList();

            homeVM.homeSliders = sliderList;
            homeVM.services = servicesList;

            return View(homeVM);
        }

        public IActionResult About()
        {
            HomeVM homeVM = new HomeVM();

            List<Person> personList = new List<Person>();
            personList = _context.People.ToList();
            homeVM.people = personList;

            return View(homeVM);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }

        public IActionResult WorkSingle(int Id)
        {
            if (Id == null) return BadRequest();
            Works Work = _context.Works
                .Include(x => x.WorkImages)
                .FirstOrDefault(x => x.Id == Id);
            

            return View(Work);
        }

        public IActionResult Work() 
        {
            HomeVM homeVM = new HomeVM();

            List<Works> works = new List<Works>();
            works = _context.Works
                .Include(x => x.WorkImages)
                .ToList();
            List<Category> categories = new List<Category>();
            categories = _context.Categories.ToList();

            homeVM.categories = categories;
            homeVM.works = works;

            return View(homeVM);
        }

    }
}
