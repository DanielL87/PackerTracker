using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace Categories.Tests
{
  [TestClass]
    public class CategoryTest : IDisposable
  {
        public void Dispose()
    {
      Category.ClearAll();
    }

   [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);

    //Act
    string result = newCategory.GetName();

    //Assert
    Assert.AreEqual(name, result);
  }
  
    [TestMethod]
  public void GetId_ReturnsCategoryId_Int()
  {
    //Arrange
    string name = "Test Category";
    Category newCategory = new Category(name);

    //Act
    int result = newCategory.GetId();

    //Assert
    Assert.AreEqual(1, result);
  }

    [TestMethod]
  public void GetAll_ReturnsAllCategoryObjects_CategoryList()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Category newCategory1 = new Category(name01);
    Category newCategory2 = new Category(name02);
    List<Category> newList = new List<Category> { newCategory1, newCategory2 };

    //Act
    List<Category> result = Category.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void Find_ReturnsCorrectCategory_Category()
  {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    Category newCategory1 = new Category(name01);
    Category newCategory2 = new Category(name02);

    //Act
    Category result = Category.Find(2);

    //Assert
    Assert.AreEqual(newCategory2, result);
  }

  [TestMethod]
  public void GetItems_ReturnsEmptyItemList_ItemList()
  {
    //Arrange
    string name = "Work";
    Category newCategory = new Category(name);
    List<Catalog> newList = new List<Catalog> { };

    //Act
    List<Catalog> result = newCategory.GetItems();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
  public void AddItem_AssociatesItemWithCategory_ItemList()
  {
    //Arrange
    Catalog newItem = new Catalog("location", "month", 32, "description");
    List<Catalog> newList = new List<Catalog> { newItem };
    string name = "Work";
    Category newCategory = new Category(name);
    newCategory.AddItem(newItem);

    //Act
    List<Catalog> result = newCategory.GetItems();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }





  }
}