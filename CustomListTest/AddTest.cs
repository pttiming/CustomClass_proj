using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace CustomListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void Add_OnePositiveValue_Count1()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;

            int expected = 1;
            int actual;

            //Act
            customList.Add(value1);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TenPositiveValue_Count10()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;
            int value10 = 10;

            int expected = 10;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Add(value10);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_TwoListsWithThreeItemsEach_Count2()
        {
            //Arrange
            CustomList<List<String>> customList = new CustomList<List<string>>();
            List<String> strings1 = new List<string>() { "Bob", "Chris", "Mike" };
            List<String> strings2 = new List<string>() { "Smith", "Wallace", "Jones" };
            

            int expected = 2;
            int actual;

            //Act
            customList.Add(strings1);
            customList.Add(strings2);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_TenPositiveValue_ValueatIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;
            int value10 = 10;

            int expected = 1;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Add(value10);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}

