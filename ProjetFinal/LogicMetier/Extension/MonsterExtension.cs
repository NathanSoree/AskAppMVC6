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
                IsWide = monsterTO.IsWide,
                Name = monsterTO.Name,
                Type = monsterTO.Type,
                Size = monsterTO.Size,
                IsDeleted = monsterTO.IsDeleted
            };
        }

        public static MonsterTO ToTO(this Monster monster)
        {
            return new MonsterTO
            {
                Id = monster.Id,
                Title = monster.Title,
                Author = monster.Author,
                IsWide = monster.IsWide,
                Name = monster.Name,
                Type = monster.Type,
                Size = monster.Size,
                IsDeleted = monster.IsDeleted
            };
        }
        
    }
}
