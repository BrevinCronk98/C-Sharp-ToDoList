using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Categories.Tests
{
    [TestClass]
    public class CategoryTest
    {

        // Test One
        [TestMethod]
        public void CategoryConstructor_CreatesInstanceOfCategory_Category()
        {
        Category newCategory = new Category("test category");
        Assert.AreEqual(typeof(Category), newCategory.GetType());
        }
    }
}