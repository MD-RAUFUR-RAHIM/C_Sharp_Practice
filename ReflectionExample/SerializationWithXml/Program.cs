using SerializationWithXml;

var course = new Course
{
    Id = null,
    Title = null,
    Supervisor = null,
    Teacher = new Instructor
    {
        Name = "Mr X",
        Email = "@gmail.com",
        PermanentAddress = new Address
        {
            City = "Basail",
            Street = "201",
            Country = "Bagladesh",
            PhoneNumbers = new List<Phone>
            {
            new Phone {   Number = "123-456-7890", CountryCode ="Bd", Extension="++8"},
            new Phone {   Number = "987-654-3210", CountryCode ="Bd", Extension="++8" }
            }
        },
        PresentAddress = new Address
        {
            City = "Sabalia",
            Street = "202",
            Country = "Bangladesh",
            //PhoneNumbers = new List<Phone>
            //        {
            //        new Phone {   Number = "123-456-7890", CountryCode ="Bd", Extension="++8"},
            //        new Phone {   Number = "987-654-3210", CountryCode ="Bd", Extension="++8" }
            //        }
        },
        PhoneNumbers = new List<Phone> { null},
        
    },
    Topics = new List<Topic>
    {
        new Topic
        {
            Title = "This is Topic",
            Description = "This is Topic Description",
            Sessions = new List<Session>
            {
                new Session
                {
                    DurationInHour = 5,
                    LearningObjective = "Learning Objective is to create a serial"
                }
            }
        }
    },
    Fees = 4.54,
    Tests = new List<AdmissionTest>
    {
        new AdmissionTest
        {
           StartDateTime = new DateTime(2022, 10, 3, 9, 9, 9),
           EndDateTime = new DateTime(2022, 10, 3, 11, 11, 11),
           TestFees = 100
        }
    },
    Tags = new string[] { "C#", "HTML", "CSS" },

    StartDate = DateTime.Now
};

string xml = XmlSerializer.Serialize(course);
Console.WriteLine(xml);
