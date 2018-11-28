using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace Catalogs.Tests
{
  [TestClass]
  public class CatalogsTest 
    {
    [TestMethod]
    public void Location_GetLocation_String()
    {
        Catalog newLocation = new Catalog("utah", "may", 32, "camping");
        Assert.AreEqual("utah", newLocation.GetLocation());
    }

    [TestMethod]
    public void Location_SetLocation_String()
    {
        //Arrange
        string location = "utah";
        Catalog newLocation = new Catalog(location, "may", 32, "camping");

        //Act
        string updatedLocation = newLocation.GetLocation();
        newLocation.SetLocation(updatedLocation);
        Assert.AreEqual("utah", updatedLocation);
    }

    [TestMethod]
    public void Location_GetBudget_Int()
    {
        Catalog newBudget = new Catalog("utah", "may", 32, "camping");
        Assert.AreEqual(32, newBudget.GetBudget());
    }

    }   
}   