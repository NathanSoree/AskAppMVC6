using Common.Enumerations;
using Common.TransferObjects;
using DAL;
using LogicMetier.Domain;
using LogicMetier.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicMetier
{
    public class AuthorUseCase
    {
        private IRepository<MonsterTO> monsterRepository;
        public AuthorUseCase(IRepository<MonsterTO> monsterRepository)
        {
            this.monsterRepository = monsterRepository ?? throw new ArgumentNullException(nameof(monsterRepository));
        }

        

        public List<MonsterTO> GetMonsterMarket()
        {
            var testMarket = monsterRepository.GetAll().Select(x => x.ToDomain());
            if (testMarket.Any(x => !x.IsValid())) throw new Exception();
            return testMarket.Select(x => x.ToTO()).ToList();
        }
        public List<MonsterTO> GetMonsterManual()
        {
            var testManual = monsterRepository.GetAll().Select(x => x.ToDomain());
            if (testManual.Any(x => !x.IsValid())) throw new Exception();
            return testManual.Select(x => x.ToTO()).ToList();
        }

        public MonsterTO GetMonster(int id)
        {
            var testMarketDetails = monsterRepository.GetById(id).ToDomain();
            if (!testMarketDetails.IsValid()) throw new Exception();
            return testMarketDetails.ToTO();
        }

    }
}
