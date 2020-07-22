using Common.TransferObjects;
using DAL;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicMetier.Extension
{
    public static class MonsterExtension
    {
        public static Monster ToDomain(this MonsterTO monsterTO)
        {
            return new Monster
            {
                Id = monsterTO.Id,
                Title = monsterTO.Title,
                Author = monsterTO.Author,
                Name = monsterTO.Name,
                Kind = monsterTO.Kind,
                Size = monsterTO.Size
            };
        }

        public static MonsterTO ToTO(this Monster monster)
        {
            return new MonsterTO
            {
                Id = monster.Id,
                Title = monster.Title,
                Author = monster.Author,
                Name = monster.Name,
                Kind = monster.Kind,
                Size = monster.Size
            };
        }
        
    }
}
