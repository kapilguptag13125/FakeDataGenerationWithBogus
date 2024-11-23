using Bogus;

namespace BogusDataGeneration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1) // Auto-increment Id
            .RuleFor(u => u.FullName, r => $"{r.Name.Suffix()}-{r.Name.FullName()}") // Random full name
            .RuleFor(u => u.Email, f => f.Internet.Email()) // Random email
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber()) // Random phone number
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(30, DateTime.Now.AddYears(-18))) // Date of birth between 18 and 48 years ago
            .RuleFor(u => u.Address, f => f.Address.FullAddress()); // Random address

            List<User> fakeUsers = userFaker.Generate(10);

            foreach (var user in fakeUsers)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
