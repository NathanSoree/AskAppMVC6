using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetFinal.Models;
using Common.Enumerations;
using LogicMetier;
using Common.TransferObjects;
using Microsoft.VisualBasic;

namespace ProjetFinal.Controllers
{
    public class ManualController : Controller
    {
        private readonly AuthorUseCase author;

        public ManualController(AuthorUseCase author)
        {
            this.author = author ?? throw new ArgumentNullException(nameof(author));
        }

        // GET: MonsterController
        public ActionResult Index()
        {
            var manual = author.GetMonsterManual();
            return View(manual);
        }

        // GET: MonsterController/Details/5
        public ActionResult Details(int id)
        {
            var monstre = new MonsterTO
            {
                Id = id,
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
                if (ModelState.IsValid)
                {
                    var monster = new MonsterTO     
                    {
                         Id     =0,
                         Title  =collection["Title"],
                         Author =collection["Author"],
                         Name   =collection["Name"],
                         Kind   =(Kind)Enum.Parse(typeof(Kind),collection["Kind"].ToString()),
                         Size   =(Size)Enum.Parse(typeof(Size),collection["Size"].ToString())  
                    };
                    author.CreateMonster(monster);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: MonsterController/Clone/5
        public ActionResult Clone(int id)
        {
            var testClone = new MonsterTO
            {
                Id = 0,
                Title = "Belgium's pride",
                Name = "French fries",
                Size = Size.Small,
                Kind = Kind.Plants
            };
            testClone.Id = 67;
            return RedirectToAction(nameof(Edit),new { id = testClone.Id });
        }       

        // GET: MonsterController/Edit/5
        public ActionResult Edit(int id)
        {
            /*var test = new MonsterTO
            {
                Id = id,
                Title ="America's dream",
                Name = "Black pudding",
                Size = Size.Large,
                Kind = Kind.Oozes
            };*/
            return View(/*test*/);
        }

        // POST: MonsterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var monster = new MonsterTO
                    {
                        Id = id,
                        Title = collection["Title"],
                        Author = collection["Author"],
                        Name = collection["Name"],
                        Kind = (Kind)Enum.Parse(typeof(Kind), collection["Kind"].ToString()),
                        Size = (Size)Enum.Parse(typeof(Size), collection["Size"].ToString())
                    };
                    author.CreateMonster(monster);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: MonsterController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteTest = new MonsterTO
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
