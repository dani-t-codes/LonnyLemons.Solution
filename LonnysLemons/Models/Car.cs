using System.Collections.Generic;

namespace Dealership.Models {
  public class Car
  {
    private string _makeModel; //private field
    //Public properties
    public string MakeModel { get; set; } //public property
    private int _price { get; set; }
    private int _miles { get; set; } 

    //List Constructor 
    public string CarDescription { get; set; }
    //Car List
    private static List<Car> _carsList = new List<Car> {};
    public Car(string carDescription)
    {
      CarDescription = carDescription;
    }

    public static List<Car> GetAll()
    {
      return _carsList;
    }

    public static void ClearAll()
    {
      _carsList.Clear();
    }

    public Car(string makeModel, int price, int miles)
    {//below are fields
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _carsList.Add(this);
    }

    public static string MakeSound(string sound)
    {
        return "Our cars sounds like " + sound;
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