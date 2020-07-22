using System;
using System.Collections.Generic;
using System.Linq;
using Common.Interfaces;
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
        public void Clone_Correct()
        {
            int id = 20;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(testHelper.testMonster(id));
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(testHelper.testMonster(id + 1));
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new ManualController(author);

            var actionResult = controller.Clone(id) as RedirectToActionResult;

            Assert.AreNotEqual(typeof(MonsterTO), actionResult.GetType());
        }

        [TestMethod()]
        public void Create_Correct()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(testHelper.testMonster(36));
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new ManualController(author);
            var monstre = testHelper.testMonster(0);

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsNotNull(result);


            //Fait TOUT SEUL COMME UN GRAND
        }

        [TestMethod]
        public void Index_Correct()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetAll()).Returns(new List<MonsterTO> { testHelper.testMonster(1), testHelper.testMonster(2) });
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
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(testHelper.testMonster(id));
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
        public void Detail_ThrowException_InvalidId()
        {
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            var author = new AuthorUseCase(mocqRepo.Object);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => author.GetMonster(-1));
        }

        [TestMethod]
        public void ManualController_NoAuthor_RaiseArgumentNullException()
        {
            //Assert
            Assert.ThrowsException<ArgumentNullException>(() => new AuthorUseCase(null));
        }

        [TestMethod]
        public void Edit_Correct()
        {
            var id = 108;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(testHelper.testMonster(id));
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(new MonsterTO { Id = id });
            var monstre = testHelper.testMonster(id);
            var author = new AuthorUseCase(mocqRepo.Object);
            var controller = new ManualController(author);

            var actionResult = controller.Edit(id) as ViewResult;
            var data = actionResult.Model as MonsterTO;

            Assert.AreEqual(id, data.Id);


        }
    }
}
