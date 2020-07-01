using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetFinal.Models;
using Common.Enumerations;

namespace ProjetFinal.Controllers
{
    public class MonsterController : Controller
    {
        // GET: MonsterController
        public ActionResult Index()
        {
            var list = new List<MonsterViewModel>
            {
                new MonsterViewModel
                {
                    Id=1,
                    Title="Strahd Von Zavorich",
                    Name="Vampire",
                    Size=Size.Medium,
                    Kind=Kind.Undead
                },
                new MonsterViewModel
                {
                    Id=2,
                    Title="Godzilla sans laser",
                    Name="Tarrasque",
                    Size=Size.Gargantuan,
                    Kind=Kind.Monstrosities
                }
            };
            return View(list);
        }

        // GET: MonsterController/Details/5
        public ActionResult Details(int id)
        {
            var monstre = new MonsterViewModel
            {
                Id = 54,
                Title= "Bruce / Lou",
                Name = "Hyena",
                Size = Size.Small,
                Kind = Kind.Beasts
            };
            return View(monstre);
        }

        // GET: MonsterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonsterController/Create
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

        // GET: MonsterController/Edit/5
        public ActionResult Edit(int id)
        {
            var test = new MonsterViewModel
            {
                Id = 42,
                Title ="America's dream",
                Name = "Black pudding",
                Size = Size.Large,
                Kind = Kind.Oozes
            };
            return View(test);
        }

        // POST: MonsterController/Edit/5
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

        // GET: MonsterController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteTest = new MonsterViewModel
            {
                Id = 59687,
                Title = "Baldur's gate 3",
                Name = "Mindflayer",
                Size = Size.Medium,
                Kind = Kind.Aberrations
            };
            return View(deleteTest);
        }

        // POST: MonsterController/Delete/5
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
