using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

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

        [TestMethod]
        public void ConvertListofStringsstoString_Result1234()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() { "1", "2", "3", "4" };
            string expected = "1234";
            string actual;

            //Act
            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ConvertListofListtoString_Result1234512345()
        {
            //Arrange
            List<string> myList = new List<string>() { "1", "2", "3", "4" };
            List<string> myList2 = new List<string>() { "1", "2", "3", "4" };
            CustomList<List<string>> customList = new CustomList<List<string>>() { myList, myList2 };

            string expected = "12341234";
            string actual;

            //Act
            actual = customList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ConvertListofStringsstoString_Result12345()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() { "1", "2", "3", "4", "5" };
            string expected = "12345";
            string actual;

            //Act
            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
