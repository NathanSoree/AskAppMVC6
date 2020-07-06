using System;
using System.Collections.Generic;
using System.Linq;
using Common.TransferObjects;
using DAL;
using LogicMetier;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjetFinal.Controllers;

namespace ProjetFinalTests.ProjetFinalTests.Controller
{
    [TestClass]
    public class ManualControllerTests
    {
        [TestMethod]
        public void Index_Correct()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetAll()).Returns(new List<MonsterTO> { new MonsterTO { }, new MonsterTO { } });
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new ManualController(author);

            // Act
            var actionResult = controller.Index() as ViewResult;
            var data = actionResult.Model as List<MonsterTO>;

            //Assert
            Assert.AreEqual(2, data.Count());
            Assert.AreEqual(typeof(List<MonsterTO>), data.GetType());
        }

        [TestMethod]
        public void Detail_Correct()
        {
            //Arrange
            var id = 5;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(new MonsterTO { Id = id });
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new ManualController(author);

            //Act
            var actionResult = controller.Details(id) as ViewResult;
            var data = actionResult.Model as MonsterTO;

            //Assert
            Assert.AreEqual(typeof(MonsterTO), actionResult.Model.GetType());
            Assert.AreEqual(id, data.Id);
        }

        [TestMethod]
        public void ManualController_NoAuthor_RaiseArgumentNullException()
        {
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => new AuthorUseCase(null));
        }

        [TestMethod]
        public void ManualController_Something()
        {
            Assert.AreEqual(2, 2);
        }
    }
}
