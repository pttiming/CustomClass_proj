using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class SubtractionOverloadTest
    {
        [TestMethod]
        public void TwoListof2Strings_OneCommonStringInEach_ReturnAStringString()
        {
            //Arrange
            CustomList<string> string1 = new CustomList<string>() { "Brewers", "Packers", };
            CustomList<string> string2 = new CustomList<string>() { "Bears", "Packers", };
            CustomList<string> string3 = new CustomList<string>();
            int expected = 1;
            int actual;
            

            //Act
            string3 = string1 - string2;
            actual = string3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TwoListof2Strings_CommonStringOccurs2xInString1_RemovesOnlyOnce()
        {
            //Arrange
            CustomList<string> string1 = new CustomList<string>() { "Brewers", "Packers", "Badgers", "Packers" };
            CustomList<string> string2 = new CustomList<string>() { "Bears", "Packers", };
            CustomList<string> string3 = new CustomList<string>();
            int expected = 3;
            int actual;


            //Act
            string3 = string1 - string2;
            actual = string3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TwoListofInts_CommonIntOccursOnce_RemovesCommonInt_Count2()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l2 = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> l3 = new CustomList<int>();
            int expected = 2;
            int actual;


            //Act
            l3 = l1 - l2;
            actual = l3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TwoListofInts_CommonIntOccursOnce_RemovesCommonInt_Index0is3()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l2 = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> l3 = new CustomList<int>();
            int expected = 3;
            int actual;


            //Act
            l3 = l1 - l2;
            actual = l3[0];
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TwoListofInts_CommonIntOccursOnce_RemovesCommonInt_Capacityis4()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l2 = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> l3 = new CustomList<int>();
            int expected = 4;
            int actual;


            //Act
            l3 = l1 - l2;
            actual = l3.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TwoListsofIdenticalInts_Count0()
        {
            //Arrange
            CustomList<int> l1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l2 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> l3 = new CustomList<int>();
            int expected = 0;
            int actual;


            //Act
            l3 = l1 - l2;
            actual = l3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
