using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Category 
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Catalog> _items;

   public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _items = new List<Catalog>{};
    }

    public string GetName()
    {
      return _name;
    }

     public int GetId()
    {
      return _id;
    }
      public static void ClearAll()
      {
          _instances.Clear();
      }
      public static List<Category> GetAll()
    {
      return _instances;
    }

     public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }

     public List<Catalog> GetItems()
  {
    return _items;
  }

  public void AddItem(Catalog item)
  {
    _items.Add(item);
  }

  }  
}