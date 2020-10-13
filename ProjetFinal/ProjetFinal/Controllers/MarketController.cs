using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Common.Enumerations;
using LogicMetier;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetFinal.Models;

namespace ProjetFinal.Controllers
{
    public class MarketController : Controller
    {
        private readonly AuthorUseCase author;

        public MarketController(AuthorUseCase author)
        {
            this.author = author ?? throw new ArgumentNullException(nameof(author));
        }

        // GET: MarketController
        public ActionResult Index()
        {
            var market = author.GetMonsterMarket();
            return View(market);
        }

        // GET: MarketController/Details/5
        public ActionResult Details(int id)
        {
            return View(author.GetMonster(id));
        }
    }
}
