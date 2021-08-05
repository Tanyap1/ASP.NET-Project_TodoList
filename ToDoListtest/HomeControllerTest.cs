using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListtest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexReturnsResult()
        {
            var controller = new HomeController(null);
            var result = controller.Index();
            Assert.IsNotNull(result);
        }
            
[TestMethod]
public  void PrivacyLoadsPrivacyView()
        {
            var controller = new HomeController(null);
            var result = (ViewResult)controller.Privacy();

            Assert.AreEqual("Privacy", result.ViewName);
        }

    }
}
