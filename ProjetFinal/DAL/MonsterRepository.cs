using Common.Interfaces;
using Common.TransferObjects;
using Common.Extension;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Extension
{
    class MonsterRepository : IRepository<MonsterTO>
    {
        private MonsterMakerContext monsterMakerContext;

        public MonsterRepository(MonsterMakerContext monsterMakerContext)
        {
            this.monsterMakerContext = monsterMakerContext;
        }

        [ExcludeFromCodeCoverage]
        public void Dispose()
        {
            monsterMakerContext.Dispose();
        }

        public bool Delete(MonsterTO item)
        {
            if (item is null)
            {
                throw new KeyNotFoundException();
            }
            if (item.Id <= 0)
            {
                throw new ArgumentException("Id invalid");
            }

            var monster = monsterMakerContext.Monsters.FirstOrDefault(x => x.Id == item.Id);
            monsterMakerContext.Monsters.Remove(monster);
            monsterMakerContext.SaveChanges();
            return true;
        }

        public List<MonsterTO> GetAll()
        {
            var list = monsterMakerContext.Monsters.AsEnumerable()
                .Where(x => x.IsDeleted = false)
                ?.Select(x => x.ToTO()).ToList();
            if (list is null)
            {
                throw new ArgumentNullException("There is no monster in the Database");
            }
            return list;
        }

        public MonsterTO GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Monster not found, id inferior or equal than 0");
            }
            return monsterMakerContext.Monsters.FirstOrDefault(x => x.Id == id).ToTO();
        }

        public MonsterTO Upsert(MonsterTO item)
        {
            if (item is null)
            {
                throw new ArgumentNullException();
            }
            if (item.Id < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Id (Id inferior than 0)");
            }
            if (item.Id == 0)
            {
                var monsterEF = item.ToEF();

                var result = monsterMakerContext.Monsters.Add(monsterEF);
                monsterMakerContext.SaveChanges();

                return result.Entity.ToTO();
            }
            if (!monsterMakerContext.Monsters.Any(x => x.Id == item.Id))
            {
                throw new KeyNotFoundException($"Can't find Monster.");
            }

            var editedItem = monsterMakerContext.Monsters.FirstOrDefault(x => x.Id == item.Id);
            if (editedItem != default)
            {
                item.ToTrackedEF(editedItem);
            }
            monsterMakerContext.SaveChanges();

            return editedItem.ToTO();
        }
    }
}
