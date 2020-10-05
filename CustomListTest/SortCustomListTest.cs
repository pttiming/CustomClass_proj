using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class SortCustomListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 5, 4, 3, 2, 1 };
            int expected = 1;
            int actual;
            //Act
            l1 = l1.Sort();
            actual = l1[4];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
