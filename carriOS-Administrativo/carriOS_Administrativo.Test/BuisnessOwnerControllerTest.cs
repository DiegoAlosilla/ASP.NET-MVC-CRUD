using System;
using carriOS_Administrativo.Controllers;
using carriOS_Administrativo.Models.Entitties;
using carriOS_Administrativo.Models.Repository;
using carriOS_Administrativo.Models.RepositoryImpl;
using carriOS_Administrativo.Models.ServiceImpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace carriOS_Administrativo.Test
{
    [TestClass]
    public class BuisnessOwnerControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var buisnessOwner = new BuisnessOwner();
            var mockServiceBuisnessOwner = new Mock<BuisnessOwnerRepositoryImpl>();
            mockServiceBuisnessOwner.Setup(sp => sp.Save(buisnessOwner)).Returns(true);

            BuisnessOwnerController controller = new BuisnessOwnerController();
            var resultado = controller.Create(buisnessOwner);
           
            
        }
    }
}
