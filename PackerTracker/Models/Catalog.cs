using System.Collections.Generic;
using System;
using System.Linq;

namespace PackerTracker.Models
{
    public class Catalog
    {
    private int _id;  
     private string _location;
     private string _month;
     private int _budget;
     private string _description;
    private static List<Catalog> _instances = new List<Catalog> {};


    public Catalog(string location, string month, int budget, string description)
    {
    _location = location;    
    _month = month;
    _budget = budget;
    _description = description;
    _instances.Add(this);
    _id = _instances.Count();

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

    public int GetId()
    {
      return _id;
    }
    
       public static List<Catalog> GetAll()
    {
      return _instances;
    }

       public static void ClearAll()
    {
      _instances.Clear();
    }

      public static Catalog Find(int searchId)
    {
      return _instances[searchId-1];
    }

    }
}