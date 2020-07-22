using Common.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public static class MonsterExtensionDAL
    {
        public static MonsterEF ToEF(this MonsterTO monsterTO)
        {
            return new MonsterEF
            {
                Id = monsterTO.Id,
                Title = monsterTO.Title,
                Author = monsterTO.Author,
                Name = monsterTO.Name,
                Kind = monsterTO.Kind,
                Size = monsterTO.Size
            };
        }

        public static MonsterTO ToTO(this MonsterEF monster)
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
        public static MonsterEF ToTrackedEF(this MonsterTO monster, MonsterEF monsterToModify)
        {
            if (monsterToModify is null)
                throw new ArgumentNullException(nameof(monsterToModify));
            if (monster is null)
                throw new ArgumentNullException(nameof(monster));

            monsterToModify.Id = monster.Id;
            monsterToModify.Title = monster.Title;
            monsterToModify.Author = monster.Author;
            monsterToModify.Name = monster.Name;
            monsterToModify.Kind = monster.Kind;
            monsterToModify.Size = monster.Size;

            return monsterToModify;
        }
    }
}
