using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using POCMock;
using System;

namespace POCMockTestProject
{
    [TestClass]
    public class TestStartPage
    {
        [TestMethod]
        public void Test()
        {
            StartPage mockedStartPage = Mock.Of<StartPage>();
            Mock.Get(mockedStartPage).Setup(startPage
                   => startPage.Name).Returns("Ragini");

            //Console.WriteLine(mockedStartPage.Name);
            Assert.AreEqual(mockedStartPage.Name, "Ragini");
        }
    }
}
