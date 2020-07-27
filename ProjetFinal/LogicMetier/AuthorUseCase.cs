using Common.Enumerations;
using Common.Exceptions;
using Common.TransferObjects;
using Common.Interfaces;
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
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
            var testDetails = monsterRepository.GetById(id);
            if (testDetails is null) throw new ArgumentException("There is no monster");
            if (!testDetails.ToDomain().IsValid()) throw new MonsterNotValidException("The given monster isn't correct");
            return testDetails.ToDomain().ToTO();

        }

        public MonsterTO CloneMonster(int id)
        {
            var clonedMonster = GetMonster(id);
            clonedMonster.Id = 0;
            return CreateOrUpdateMonster(clonedMonster);
        }

        public MonsterTO CreateOrUpdateMonster(MonsterTO monsterTO)
        {
            try
            {
                if (monsterTO is null)
                {
                    throw new ArgumentNullException(nameof(monsterTO));
                }
                if (monsterTO.Id < 0) throw new ArgumentOutOfRangeException(nameof(monsterTO));
                var monsterDomain = monsterTO.ToDomain();
                if (!monsterDomain.IsValid()) throw new MonsterNotValidException("The given monster isn't correct");
                return monsterRepository.Upsert(monsterTO).ToDomain().ToTO();
            }
            catch (MonsterNotValidException mne)
            {
                throw mne;
                //TODO implement log
            }
            catch (AuthorNotExistingException ane)
            {
                throw ane;
                //TODO implement log
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public MonsterTO DeleteMonster(MonsterTO monster)
        {
            monster.IsDeleted = true;
            var deletedMonster = monsterRepository.Upsert(monster);
            return deletedMonster;
        }
    }
}
