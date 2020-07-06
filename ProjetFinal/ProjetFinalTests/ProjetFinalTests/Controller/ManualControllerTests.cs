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
        public void ReturnIndex_Correct()
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
    }
}
