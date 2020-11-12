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
    Car volkswagen = new Car();
    volkswagen.MakeModel = "1974 Volkswagen Thing";
    volkswagen.Price = 1100;
    volkswagen.Miles = 921647;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 123456;

    Car ford = new Car();
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 1400;
    ford.Miles = 333333;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 305;
    amc.Miles = 199000;

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