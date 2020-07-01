using Common.TransferObjects;
using Common.Enumerations;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class MonsterTempRepository : IRepository<MonsterTO>
    {
        public MonsterTO GetById(int id)
        {
            return new MonsterTO
            {
                Id = 2002,
                Title = "BBEG",
                Author = "Régénaer",
                Name = "Manny, demoted commander",
                Size = Size.Small,
                Kind = Kind.Humanoids
            };
        }

        public List<MonsterTO> GetAll()
        {
            var testMarket = new List<MonsterTO>
            {
                new MonsterTO
                {
                    Id=31418,
                    Title="Pixie for 2 players",
                    Author="Fée Lectricité",
                    Name="Pixie",
                    Size=Size.Tiny,
                    Kind=Kind.Fey
                },
                new MonsterTO
                {
                    Id=2002,
                    Title="BBEG",
                    Author="Régénaer",
                    Name="Manny, demoted commander",
                    Size=Size.Small,
                    Kind=Kind.Humanoids
                }
            };
            return testMarket;
        }
    }
}
