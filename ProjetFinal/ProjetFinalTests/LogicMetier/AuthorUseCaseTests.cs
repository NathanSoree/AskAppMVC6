using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicMetier;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Moq;
using Common.TransferObjects;
using Common.Exceptions;

namespace ProjetFinalTests.LogicMetier
{
    [TestClass()]
    public class AuthorUseCaseTests
    {
        [TestMethod()]
        public void GetMonster_ReturnMonster_WhenValid()
        {
            //Arrange
            var id = 42;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(testHelper.testMonster(id));
            var author = new AuthorUseCase(mocqRepo.Object);

            //Act
            var result = author.GetMonster(id);

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
            
        }
        [TestMethod()]
        public void GetMonster_ThrowsException_InvalidId()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            var author = new AuthorUseCase(mocqRepo.Object);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => author.GetMonster(-1));

        }
        
        [TestMethod()]
        public void GetMonster_ThrowException_InexistentMonster()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Throws(new MonsterNotExistingException());
            var author = new AuthorUseCase(mocqRepo.Object);

            //Assert

            Assert.ThrowsException<MonsterNotExistingException>(() => author.GetMonster(546));

        }
        //1 Tester la création (réussite) et l'update (échec) quand Id = 0
        //2 Tester la création (échec) et l'update (réussite) quand Id !=0 & existant en DB
        //3 Tester l'update quand Id != 0 et non-existant (échec)
        //4 Tester la création et l'update quand MonsterTO invalide (échec)
        //5 Tester la création et l'update quand pas d'auteur en DB
        //6 Throw exception id<0

        [TestMethod()]
        public void CreateOrUpdateMonster_Create_WhenIdEquals0()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(testHelper.testMonster(59));
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(0);

            //Act
            var result = author.CreateOrUpdateMonster(monstre);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void CreateOrUpdateMonster_Update_WhenIdIsStrictlySuperior0AndInDatabase()
        {
            var id = 543;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(new MonsterTO { Id = id });
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(id);

            //Act
            var result = author.CreateOrUpdateMonster(monstre);

            //Assert
            Assert.AreEqual(id, monstre.Id);
        }

        [TestMethod]
        public void CreateOrUpdateMonster_ThrowExcepton_WhenIdIsStrictlySuperior0AndNotInDatabase()
        {
            var id = 543;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Throws(new MonsterNotExistingException());
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(id);            

            Assert.ThrowsException<MonsterNotExistingException>(() => author.CreateOrUpdateMonster(monstre));
        }

        [TestMethod]
        public void CreateOrUpdateMonster_ThrowExcepton_WhenMonsterTONotValid()
        {
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Throws(new MonsterNotValidException());
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = new MonsterTO();

            Assert.ThrowsException<MonsterNotValidException>(() => author.CreateOrUpdateMonster(monstre));
        }

        [TestMethod]
        public void CreateOrUpdateMonster_ThrowExcepton_WhenAuthorNotInDatabase()
        {
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Throws(new AuthorNotExistingException());
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(546);

            Assert.ThrowsException<AuthorNotExistingException>(() => author.CreateOrUpdateMonster(monstre));
        }

        [TestMethod]
        public void CreateOrUpdateMonster_ThrowExcepton_IdInferiorThan0()
        {
            //Arrange
            var mocqRepo = new Mock<IRepository<MonsterTO>>();            
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(-5);


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => author.CreateOrUpdateMonster(monstre));
        }
        [TestMethod]
        public void CloneMonster_Correct()
        {
            int id = 144;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.GetById(It.IsAny<int>())).Returns(testHelper.testMonster(id));
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(testHelper.testMonster(id+1));

            var author = new AuthorUseCase(mocqRepo.Object);
            //Act
            var result = author.CloneMonster(id);

            //Assert
            Assert.AreNotEqual(id, result.Id);
        }

        [TestMethod]
        public void DeleteMonster_Correct()
        {
            int id = 161;
            var mocqRepo = new Mock<IRepository<MonsterTO>>();
            mocqRepo.Setup(x => x.Upsert(It.IsAny<MonsterTO>())).Returns(new MonsterTO { Id = id });
            var author = new AuthorUseCase(mocqRepo.Object);
            var monstre = testHelper.testMonster(id);

            //Act
            var result = author.CreateOrUpdateMonster(monstre);

            //Assert
            Assert.AreEqual(id, monstre.Id);
        }
    }
}