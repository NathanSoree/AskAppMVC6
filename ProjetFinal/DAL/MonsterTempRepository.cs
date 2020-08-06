using Common.TransferObjects;
using Common.Enumerations;
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class MonsterTempRepository : IRepository<MonsterTO>
    {
        public bool Delete(MonsterTO item)
        {
            if (item is null)
            {
                throw new ArgumentNullException("Ce monstre n'existe pas");
            }
            if (item.Id <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return true;
        }

        public MonsterTO GetById(int id)
        {
            return new MonsterTO
            {
                Id = 2002,
                Title = "BBEG",
                Author = "Régénaer",
                Name = "Manny, demoted commander",
                Size = Size.Small,
                Type = Common.Enumerations.Type.Humanoids
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
                    Type= Common.Enumerations.Type.Fey
                },
                new MonsterTO
                {
                    Id=2002,
                    Title="BBEG",
                    Author="Régénaer",
                    Name="Manny, demoted commander",
                    Size=Size.Small,
                    Type= Common.Enumerations.Type.Humanoids
                }
            };
            return testMarket;
        }

        public MonsterTO Upsert(MonsterTO item)
        {
            item.Id = item.Id == 0 ? 51 : item.Id;
            return item;
        }
        
    }
}
