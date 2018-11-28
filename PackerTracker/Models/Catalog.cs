using System.Collections.Generic;
using System;

namespace PackerTracker.Models
{
    public class Catalog
    {
     private string _location;
     private string _month;
     private int _budget;
     private string _description;



    public Catalog(string location, string month, int budget, string description)
    {
    _location = location;    
    _month = month;
    _budget = budget;
    _description = description;

    }


// Setters
    public void SetLocation(string newLocation)
    {
        _location = newLocation;
    }


    public void SetMonth(string newMonth)
    {
        _month = newMonth;
    }

    public void SetBudget(int newBudget)
    {
        _budget = newBudget;
    }
    public void SetDescription(string newDescription)
    {
        _description = newDescription;
    }


// Getters

      public string GetLocation()
    {
      return _location;
    }

    public string GetMonth()
    {
        return _month;
    }

    public int GetBudget()
    {
        return _budget;
    }

    public string GetDescription()
    {
        return _description;
    }

    }
}