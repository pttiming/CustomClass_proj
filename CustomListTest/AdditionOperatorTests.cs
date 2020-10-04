using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;


namespace CustomListTest
{
    [TestClass]
    public class AdditionOperatorTests
    {
        [TestMethod]
        public bool AdditionOperatorOverload_TwoIntLists()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> l2 = new CustomList<int>() { 5, 6, 7, 9 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act
            CustomList<int> actual = (l1 + l2);
            //Assert
            if (expected.Equals(actual))
                return true;
            else
                return false;

        }

        [TestMethod]
        public void AdditionOperatorOverload_TwoStringLists()
        {
            //Arrange
            CustomList<string> l1 = new CustomList<string>() { "1", "2", "3", "4" };
            CustomList<string> l2 = new CustomList<string>() { "5", "6", "7", "8" };

            //Act
            CustomList<string> l3 = (l1 + l2);
            string expected = "12345678";
            string actual = l3.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
            

        }

        [TestMethod]
        public void AdditionOperatorOverload_TwoStringLists_IndexValue7()
        {
            //Arrange
            CustomList<string> l1 = new CustomList<string>() { "1", "2", "3", "4" };
            CustomList<string> l2 = new CustomList<string>() { "5", "6", "7", "8" };
            string expected = "8";
            string actual;

            //Act
            CustomList<string> test = (l1 + l2);
            actual = test[7];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AdditionOperatorOverload_TwoIntListsof3Items_Count6()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> l2 = new CustomList<int>() { 5, 6, 7 };
            CustomList<int> l3 = new CustomList<int>();
            int expected = 6;
            int actual;

            //Act
            l3 = (l1 + l2);
            actual = l3.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
