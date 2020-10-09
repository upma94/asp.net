using System;
using CalculatorApp.Controllers;
using CalculatorApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        HomeController homeController;
        CalculatorModels calculatorModels;
        [TestInitialize]
        public void CreateController()
        {
            homeController = new HomeController();
            calculatorModels = new CalculatorModels();            
        }       

        [TestMethod]
        public void TestMethod1()
        {            
            //Act
            var result = homeController.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Act
            var result = homeController.Index() as ViewResult;

            //Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string command = "add";                       

            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string command = "sub";
            
            
            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string command = "mul";           
            
            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string command = "div";
            //CalculatorModels model = null;
            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange

            CalculatorModels model = null;

            //Act
            ViewResult result = homeController.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
