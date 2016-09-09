using System;
using System.Collections.Generic;

namespace Cds.Objects
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};
    private string _title;
    private string _artist;
    private int _price;
    private List<Cd> _cds;

    public Cd(string Title, string Artist, int Price)
    {
      _title = Title;
      _artist = Artist;
      _price = Price;
      _instances.Add(this);
      _cds = new List<Cd>{};
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static List<Cd> GetAll()
   {
     return _instances;
   }
  }
}
