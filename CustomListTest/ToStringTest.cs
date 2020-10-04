using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void ConvertListofIntstoString_Result12345()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4 };
            string expected = "1234";
            string actual;

            //Act
            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
