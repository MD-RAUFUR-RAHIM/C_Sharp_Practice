using JoinInLinq;

List<Person> person = new List<Person>
{
    new Person { Name = "Alice", CityId = 1 },
    new Person { Name = "Bob", CityId = 2 },
    new Person { Name = "Charlie", CityId = 1 }
};
List<City> cities = new List<City>
{
    new City { CityId = 1, CityName = "New York" },
    new City { CityId = 2, CityName = "Los Angeles" }
};

#region Code Explanation
    /*sequence1.Join(
    sequence2,       // The second sequence to join with
    keySelector1,    // The key selector for the first sequence
    keySelector2,    // The key selector for the second sequence
    resultSelector   // How to combine elements from both sequences
);*/

#endregion

var joinQuery = person.Join(
    cities,                           // 1. The second sequence to join (cities)
    person => person.CityId,         // 2. The key selector for people: We use `CityId` to match
    city => city.CityId,            // 3. The key selector for cities: We use `CityId` to match
    (person, city) => new          // 4. The result selector: This defines what data to return
    {
        PersonName = person.Name,
        CityName = city.CityName
    });
foreach (var item in joinQuery)
{
    Console.WriteLine($"Name: {item.PersonName}, City: {item.CityName}");
}