using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class ZipperMergeTest
    {
        [TestMethod]
        public void TwoIntCustomListTest_3IntsEach_Index1IsList2IndexZero()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> list3;
            int expected = 2;
            int actual;

            //Act
            list3 = new CustomList<int>();
            list3 = list3.ZipperMerge(list1, list2);
            actual = list3[1];
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TwoIntCustomListTest_3IntsEach_Count6()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> list3;
            int expected = 6;
            int actual;

            //Act
            list3 = new CustomList<int>();
            list3 = list3.ZipperMerge(list1, list2);
            actual = list3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TwoIntCustomListTest_3IntsList5IntList_Count8()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            CustomList<int> list3;
            int expected = 8;
            int actual;

            //Act
            list3 = new CustomList<int>();
            list3 = list3.ZipperMerge(list1, list2);
            actual = list3.Count;
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TwoIntCustomListTest_3IntsList5IntList_Capacity8()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> list2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> list3;
            int expected = 8;
            int actual;

            //Act
            list3 = new CustomList<int>();
            list3 = list3.ZipperMerge(list1, list2);
            actual = list3.Capacity;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
