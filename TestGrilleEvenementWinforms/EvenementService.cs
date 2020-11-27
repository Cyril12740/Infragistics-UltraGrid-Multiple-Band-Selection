using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TestGrilleEvenement.Data;

namespace TestGrilleEvenementWinforms
{
    class EvenementService
    {
        public static IEnumerable<Evenement> FakeEvements(int count)
        {
            return Enumerable.Range(0, count).Select(e => new Evenement()
            {
                Title = $"Item-{e}",
                Company = Faker.Company.Name(),
                DateTime = Faker.Identification.DateOfBirth(),
                Evenements = e % 5 == 0
                    ? Enumerable.Range(0, 3).Select(f => new SubEvenement()
                    {
                        Title = $"SubItem-{f}",
                        Company = Faker.Company.Name(),
                        DateTime = Faker.Identification.DateOfBirth(),
                        Color = RandomColor
                    }).ToList()
                    : new List<SubEvenement>(),
                Color = RandomColor
            });
        }

        public static Color RandomColor => Color.FromArgb(Faker.RandomNumber.Next(0, 255),
            Faker.RandomNumber.Next(0, 255), Faker.RandomNumber.Next(0, 255));
    }
}
