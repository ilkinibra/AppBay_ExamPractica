using AppBay_BackEnd.DAL;
using AppBay_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay_BackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController : Controller
    {
        private AppDbContext _context;
        public CardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Card> card = _context.Cards.ToList();
            return View(card);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Card card = await _context.Cards.FindAsync(id);
            if (card == null) return NotFound();
            return View(card);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Card card = await _context.Cards.FindAsync(id);
            if (card == null) return NotFound();
            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Card newcard=new Card();
            newcard.IconPath = card.IconPath;
            newcard.Title = card.Title;
            newcard.Description = card.Description;
            await _context.Cards.AddAsync(newcard);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
