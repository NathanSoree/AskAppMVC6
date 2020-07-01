using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Enumerations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetFinal.Models;

namespace ProjetFinal.Controllers
{
    public class MarketController : Controller
    {
        // GET: MarketController
        public ActionResult Index()
        {
            var testMarket = new List<MonsterViewModel>
            {
                new MonsterViewModel
                {
                    Id=31418,
                    Title="Pixie for 2 players",
                    Author="Fée Lectricité",
                    Name="Pixie",
                    Size=Size.Tiny,
                    Kind=Kind.Fey
                },
                new MonsterViewModel
                {
                    Id=2002,
                    Title="BBEG",
                    Author="Régénaer",
                    Name="Manny, demoted commander",
                    Size=Size.Small,
                    Kind=Kind.Humanoids
                }
            };
            return View(testMarket);
        }

        // GET: MarketController/Details/5
        public ActionResult Details(int id)
        {
            var detailMarket = new MonsterViewModel
            {
                Id = 1334,
                Title = "Manque d'inspi",
                Author = "Moi",
                Name = "Développeur .Net",
                Size = Size.Medium,
                Kind = Kind.Humanoids
            };
            return View(detailMarket);
        }

        // GET: MarketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarketController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarketController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
