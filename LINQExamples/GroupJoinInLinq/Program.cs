using GroupJoinInLinq;

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

var groupJoinQuery = people.GroupJoin(
    cities,
    people => people.CityId,
    city => city.CityId,
    (person, city) => new
    {
        PersonName = person.Name,
        CityNames = city.Select(c => c.CityName).DefaultIfEmpty("No City") // Handle people with no city
    });
Console.WriteLine("From Group Join Method");
foreach (var item in groupJoinQuery)
{
    Console.WriteLine($"Name: {item.PersonName}, Cities: {string.Join(", ", item.CityNames)}");
}

var leftJoinMethod = people.GroupJoin(cities,
    people => people.CityId,
    city => city.CityId,
    (person, city) => new
    {
        person,
        city
    }).SelectMany(
     result =>result.city.DefaultIfEmpty(),
     (result, city) => new
     {
         PersonName = result.person.Name,
         CityName = city != null ? city.CityName : "No City"
     });
Console.WriteLine();
Console.WriteLine("From Left Join Method");
foreach (var item in leftJoinMethod)
{
    Console.WriteLine($"Name: {item.PersonName} City: {item.CityName}");
}

var rightJoinMethod = cities.GroupJoin(
    people, // Inner sequence
    city => city.CityId, // Outer key selector
    person => person.CityId, // inner key selector
    (city, person)=> new
    {
        city,
        person
    }).SelectMany(
     result => result.person.DefaultIfEmpty(), // Ensures Right Join
        (result, person) => new
        {
            CityName = result.city.CityName,
            PersonName = person != null ? person.Name : "No Person"
        }
    );

Console.WriteLine();
Console.WriteLine("From Right Join Method");
foreach (var item in rightJoinMethod)
{
    Console.WriteLine($"Name: {item.PersonName} City: {item.CityName}");
}
