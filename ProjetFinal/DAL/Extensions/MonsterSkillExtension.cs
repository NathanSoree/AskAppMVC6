using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterSkillExtension
    {
        public static List<MonsterSkillEF> ToEFSkill(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterSkillEF>();
            foreach (var x in monsterTO.Skills)
            {
                returnList.Add(new MonsterSkillEF
                {
                    MonsterId = monsterId,
                    IdEnumSkill= (int)x.Key,
                    IdEnumProf = (int)x.Value
                });
            }
            return returnList;
        }
        public static Dictionary<Skill, Proficiency> ToTOSkill(this List<MonsterSkillEF> skillEF)
        {
            var returnDictionary = new Dictionary<Skill, Proficiency>();
            foreach (var x in skillEF)
            {
                returnDictionary.Add((Skill)x.IdEnumSkill, (Proficiency)x.IdEnumProf);
            };
            return returnDictionary;
        }
    }
}
