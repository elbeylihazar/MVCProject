using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViewProject.Models;

namespace ViewProject.Controllers
{
    public class KategoriUrunTarihSatisController : Controller
    {
        private VeritabaniContext _veritabaniContext;

        public KategoriUrunTarihSatisController(VeritabaniContext veritabaniContext)
        {
            _veritabaniContext = veritabaniContext;
        }

        public IActionResult Index()
        {
            var veriler = _veritabaniContext.Satislar.ToList(); 
            return View(veriler);
        }
    }
}
