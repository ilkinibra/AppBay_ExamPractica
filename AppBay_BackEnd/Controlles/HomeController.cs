using AppBay_BackEnd.DAL;
using AppBay_BackEnd.Models;
using AppBay_BackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AppBay_BackEnd.Controlles
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();   
            homeVM.sliders = _context.Sliders.FirstOrDefault();
            homeVM.cards = _context.Cards.ToList();
            homeVM.moderns = _context.Moderns.ToList();
            return View(homeVM);
        }
    }
}
