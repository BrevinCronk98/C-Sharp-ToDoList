using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Items.Tests
{
    [TestClass]
    public class ItemTest : IDisposable
    {
        // Clear Tests After
        public void Dispose()
        {
        Item.ClearAll();
        }

        // Test One
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
        Item newItem = new Item("test");
        Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        // TestTwo
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
        //Arrange
        string description = "Walk the dog.";

        //Act
        Item newItem = new Item(description);
        string result = newItem.Description;

        //Assert
        Assert.AreEqual(description, result);
        }

        // Test Three
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
        //Arrange
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        //Act
        string updatedDescription = "Do the dishes";
        newItem.Description = updatedDescription;
        string result = newItem.Description;

        //Assert
        Assert.AreEqual(updatedDescription, result);
        }

        // Test Four
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
        // Arrange
        List<Item> newList = new List<Item> { };

        // Act
        List<Item> result = Item.GetAll();

        // Assert
        CollectionAssert.AreEqual(newList, result);
        }

        // Test Five
        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
        //Arrange
        string description01 = "Walk the dog";
        string description02 = "Wash the dishes";
        Item newItem1 = new Item(description01);
        Item newItem2 = new Item(description02);
        List<Item> newList = new List<Item> { newItem1, newItem2 };

        //Act
        List<Item> result = Item.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
        }
        // Test Six
        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
        //Arrange
        string description = "Walk the dog.";
        Item newItem = new Item(description);

        //Act
        int result = newItem.Id;

        //Assert
        Assert.AreEqual(1, result);
        }
        // Test Seven
        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
        //Arrange
        string description01 = "Walk the dog";
        string description02 = "Wash the dishes";
        Item newItem1 = new Item(description01);
        Item newItem2 = new Item(description02);

        //Act
        Item result = Item.Find(2);

        //Assert
        Assert.AreEqual(newItem2, result);
        }
    }
}