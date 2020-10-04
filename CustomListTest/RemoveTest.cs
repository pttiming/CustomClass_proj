using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_TenItemListRemove1_Count9()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int expected = 9;
            int actual;

            //Act
            customList.Remove(10);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_OneItemListRemove1_CountZero()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1 };

            int expected = 0;
            int actual;

            //Act
            customList.Remove(0);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ItemListRemove1Item_NewITemShowsNextItemInListAtRemovedItemsPreviousIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 0, 1, 2 };

            int expected = 2;
            int actual;

            //Act
            customList.Remove(1);

            actual = customList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_TenItemListRemove1FromMiddle_Count9()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int expected = 9;
            int actual;

            //Act
            customList.Remove(4);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_2ITemListRemove1Item_IndexofZeroRemainingItem()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 0, 1 };

            int expected = 1;
            int actual;

            //Act
            customList.Remove(0);

            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
