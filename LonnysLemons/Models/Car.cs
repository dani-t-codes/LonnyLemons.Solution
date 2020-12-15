using System;

namespace Dealership.Models {
  public class Car
  {
    private string _makeModel; //private field
    //Public properties
    public string MakeModel { get; set; } //public property
    private int _price { get; set; }
    private int _miles { get; set; } 

    public static string MakeSound(string sound)
    {
        return "Our cars sounds like " + sound;
    }
    //Constructor 
    public Car(string makeModel, int price, int miles)
    {//below are fields
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }

}