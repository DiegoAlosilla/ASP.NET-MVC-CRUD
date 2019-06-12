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
    }
}
