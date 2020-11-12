using System;
using System.Collections.Generic;

public class Car 
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  // constructor method parameters are in lowerCamelCase
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }
  // object's fields are in PascalCase

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}

public class Program 
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 921647);
    Car yugo = new Car("1980 Yugo Koral", 700, 123456);
    Car ford = new Car("1988 Ford Country Squire", 1400, 333333);
    Car amc = new Car("1976 AMC Pacer", 305, 199000);

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}