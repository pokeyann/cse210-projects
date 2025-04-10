using System;


public class Address : BaseEvent
{
  private string _street;
  private string _city;
  private string _stateProvince;
  private string _country;

  public Address(string street, string city, string stateProvince, string country)
  {
    _street = street;
    _city = city;
    _stateProvince = stateProvince;
    _country = country;
  }

  public string Getstreet() => _street;
  public string GetCity() => _city;
  public string GetStateProvince() => _stateProvince;
  public string GetCountry() => _country;

  public bool IsUSA() => _country == "USA";

  public string GetFullAddress()
  {
    return $"{_street} {_city}, {_stateProvince} {_country}";
  }
}