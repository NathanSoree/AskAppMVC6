using Common.TransferObjects;
using DAL;
using LogicMetier;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjetFinal.Controllers;
using System.Collections.Generic;
using System;

namespace ProjetFinalTests
{
    [TestClass]
    public class MarketControllerTests
    {
        [TestMethod]
        public void Index_ReturnMarketMonsters()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetAll()).Returns(new List<MonsterTO> { new MonsterTO { }, new MonsterTO { } });
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new MarketController(author);

            // Act
            var actionResult = controller.Index() as ViewResult;
            var data = actionResult.Model as List<MonsterTO>;

            //Assert
            Assert.AreEqual(2,data.Count());
            Assert.AreEqual(typeof(List<MonsterTO>),actionResult.Model.GetType());
        }

        [TestMethod]
        public void Index_ReturnMarketDetail()
        {
            //Arrange
            var id = 5;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(new MonsterTO {Id=id});
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new MarketController(author);

            // Act
            var actionResult = controller.Details(id) as ViewResult;
            var data = actionResult.Model as MonsterTO;

            //Assert
            Assert.AreEqual(typeof(MonsterTO), actionResult.Model.GetType());
            Assert.AreEqual(id, data.Id);
        }
    }
}
