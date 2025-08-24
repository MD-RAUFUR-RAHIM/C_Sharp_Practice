using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int? CityId { get; set; }
}

public class City
{
    public int CityId { get; set; }
    public string CityName { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", CityId = 1 },
            new Person { Name = "Bob", CityId = 2 },
            new Person { Name = "Charlie", CityId = 1 },
            new Person { Name = "David" }  // A person without a corresponding city
        };

        List<City> cities = new List<City>
        {
            new City { CityId = 1, CityName = "New York" },
            new City { CityId = 2, CityName = "Los Angeles" },
            new City {CityId = 3 , CityName ="Dhaka"}
        };

        // Left Join
        var leftJoinMethod = people.GroupJoin(
            cities,
            person => person.CityId,
            city => city.CityId,
            (person, cityGroup) => new
            {
                PersonName = person.Name,
                CityName = cityGroup.FirstOrDefault()?.CityName ?? "No City"
            });

        // Right Join
        var rightJoinMethod = cities.GroupJoin(
            people,
            city => city.CityId,
            person => person.CityId,
            (city, personGroup) => new
            {
                PersonName = personGroup.FirstOrDefault()?.Name ?? "No Person",
                CityName = city.CityName
            });

        // Full Outer Join (Union of Left and Right Join)
        var fullOuterJoin = leftJoinMethod
            .Union(rightJoinMethod)
            .Distinct(); // Removes duplicates, ensuring unique records

        // Output result
        Console.WriteLine("From Full Outer Join:");
        foreach (var item in fullOuterJoin)
        {
            Console.WriteLine($"Person: {item.PersonName}, City: {item.CityName}");
        }
    }
}
