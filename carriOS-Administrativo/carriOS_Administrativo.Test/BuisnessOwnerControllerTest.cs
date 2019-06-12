using System;
using System.Collections.Generic;
using carriOS_Administrativo.Controllers;
using carriOS_Administrativo.Models.Entitties;
using carriOS_Administrativo.Models.Repository;
using carriOS_Administrativo.Models.RepositoryImpl;
using carriOS_Administrativo.Models.Service;
using carriOS_Administrativo.Models.ServiceImpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace carriOS_Administrativo.Test
{
    [TestClass]
    public class BuisnessOwnerControllerTest
    {
        [TestMethod]
        public void RegistarBuisnessOwner()
        {
            BuisnessOwnerRepositoryImpl buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl();
            BuisnessOwner buisnessOwner = new BuisnessOwner();
            buisnessOwner.FirstName = "Diego";
            buisnessOwner.LastName = "Alosilla";
            buisnessOwner.Email = "deigoalosilla@gmail.com";
            buisnessOwner.Movil = "966450252";
            buisnessOwner.Password = "1234";
            buisnessOwner.City = "Lima";
            buisnessOwner.Country = "Peru";
            var mock = new Mock<BuisnessOwnerRepository>();
            mock.Setup(x => x.Save(buisnessOwner)).Returns(true);
            var resultado = mock.Object.Save(buisnessOwner);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ListarBuisnessOwner()
        {
            BuisnessOwnerRepositoryImpl buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl();
            var listOfBuisnessOwner = new List<BuisnessOwner>();
            listOfBuisnessOwner.Add(new BuisnessOwner
            {
                FirstName = "Diego",
                LastName = "Alosilla",
                Email = "deigoalosilla@gmail.com",
                Movil = "966450252",
                Password = "1234",
                City = "Lima",
                Country = "Peru",
            });
            BuisnessOwner buisnessOwner = new BuisnessOwner();
         
            var mock = new Mock<BuisnessOwnerRepository>();
            mock.SetupGet(x => x.FindAll()).Returns(listOfBuisnessOwner);
            var resultado = mock.Object.FindAll();
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void Test_EditarrBuisnessOwner()
        {
            BuisnessOwnerRepositoryImpl buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl();
            BuisnessOwner buisnessOwner = new BuisnessOwner();
            buisnessOwner.FirstName = "Luis";
            buisnessOwner.LastName = "Kcomt";
            buisnessOwner.Email = "luiskcomt@gmail.com";
            buisnessOwner.Movil = "968395955";
            buisnessOwner.Password = "1234";
            buisnessOwner.City = "Lima";
            buisnessOwner.Country = "Peru";
            var mock = new Mock<BuisnessOwnerRepository>();
            mock.Setup(x => x.Update(buisnessOwner)).Returns(true);
            var resultado = mock.Object.Update(buisnessOwner);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Test_EliminarBuisnessOwner()
        {
            BuisnessOwnerRepositoryImpl buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl();
            BuisnessOwner buisnessOwner = new BuisnessOwner();
            buisnessOwner.FirstName = "Luis";
            buisnessOwner.LastName = "Kcomt";
            buisnessOwner.Email = "luiskcomt@gmail.com";
            buisnessOwner.Movil = "968395955";
            buisnessOwner.Password = "1234";
            buisnessOwner.City = "Lima";
            buisnessOwner.Country = "Peru";
            var mock = new Mock<BuisnessOwnerRepository>();
            mock.Setup(x => x.Delete(buisnessOwner)).Returns(true);
            var resultado = mock.Object.Delete(buisnessOwner);
            Assert.IsTrue(resultado);
        }
    }
}
