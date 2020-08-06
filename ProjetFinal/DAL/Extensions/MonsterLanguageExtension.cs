using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class MonsterLanguageExtension
    {
        public static List<MonsterLanguageEF> ToEFLang(this MonsterTO monsterTO, int monsterId)
        {
            var returnList = new List<MonsterLanguageEF>();
            foreach (var x in monsterTO.Languages)
            {
                returnList.Add(new MonsterLanguageEF
                {
                    MonsterId = monsterId,
                    Language = x
                });
            }
            return returnList;
        }
        public static List<string> ToTOLang(this List<MonsterLanguageEF> languageEF)
        {
            var returnList = new List<string>();
            foreach (var x in languageEF)
            {
                returnList.Add(x.Language);
            };
            return returnList;
        }
    }
}