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
                Kind = Common.Enumerations.Kind.Beasts
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
                         Title  = collection["Title"],
                         Author = collection["Author"],
                         Name   = collection["Name"],
                         Kind   =(Common.Enumerations.Kind)Enum.Parse(typeof(Common.Enumerations.Kind), collection["Kind"].ToString()),
                         Size   =(Size)Enum.Parse(typeof(Size), collection["Size"].ToString())  
                    };
                    author.CreateOrUpdateMonster(monster);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction("Create");
            }
            catch
            {
                return RedirectToAction("Create");
            }
        }

        // GET: MonsterController/Clone/5
        public ActionResult Clone(int id)
        {           
            var newId = author.CloneMonster(id).Id;
            return RedirectToAction(nameof(Edit),new { id = newId });
        }       

        // GET: MonsterController/Edit/5
        public ActionResult Edit(int id)
        {
            var monster = author.GetMonster(id);
            
            return View(monster);
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
                        Kind = (Common.Enumerations.Kind)Enum.Parse(typeof(Common.Enumerations.Kind), collection["Kind"].ToString()),
                        Size = (Size)Enum.Parse(typeof(Size), collection["Size"].ToString())
                    };
                    author.CreateOrUpdateMonster(monster);
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction("Edit",new { id = id } );
            }
            catch
            {
                return RedirectToAction("Edit", new { id = id });
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
                Kind = Common.Enumerations.Kind.Aberrations
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
