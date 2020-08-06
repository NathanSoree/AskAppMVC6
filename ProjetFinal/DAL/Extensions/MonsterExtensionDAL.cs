using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Extensions
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
                IsWide = monsterTO.IsWide,
                Name = monsterTO.Name,
                Type = monsterTO.Type,
                Size = monsterTO.Size,
                Alignment = monsterTO.Alignment,
                ArmorClass = monsterTO.ArmorClass,
                Health = monsterTO.Health?.ToEF(),
                Speeds = monsterTO.Speeds?.ToEF(monsterTO.Id),
                Stats = monsterTO.ToEFStat(), // TODO after break: Commenté tous les dictionnaires... JK, faire pareil pour tous les dico
                Skills = monsterTO.ToEFSkill(monsterTO.Id),
                Vulnerabilities = monsterTO.ToEFVuln(monsterTO.Id),
                OtherVulnerabilities = monsterTO.OtherVulnerabilities,
                Resistances = monsterTO.ToEFResist(monsterTO.Id),
                OtherResistences = monsterTO.OtherResistences,
                Immunities = monsterTO.ToEFImmu(monsterTO.Id),
                OtherImmunities = monsterTO.OtherImmunities,
                ConditionImmunities = monsterTO.ToEFCondImmu(monsterTO.Id),
                Senses = monsterTO.ToEFSense(),
                Languages = monsterTO.ToEFLang(monsterTO.Id),
                DifficultyRating = monsterTO.DifficultyRating,
                Traits = monsterTO.Traits.Select(x => x.ToEF()).ToList(),
                Actions = monsterTO.Actions.Select(x => x.ToEF()).ToList(),
                NbrLegendaryActionPerTurn = monsterTO.NbrLegendaryActionPerTurn,
                LegendaryActions = monsterTO.LegendaryActions.Select(x => x.ToEF()).ToList(),
                Reactions = monsterTO.Reactions.Select(x => x.ToEF()).ToList(),
                IsDeleted = monsterTO.IsDeleted
            };
        }

        public static MonsterTO ToTO(this MonsterEF monster)
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
                Alignment = monster.Alignment,
                ArmorClass = monster.ArmorClass,
                Health = monster.Health?.ToTO(),
                Speeds = monster.Speeds?.ToTO(),
                Stats = monster.Stats?.ToTO(),
                Saving = monster.Stats?.ToSavingTO(),
                Skills = monster.Skills?.ToTOSkill(),
                Vulnerabilities = monster.Vulnerabilities?.ToTOVuln(),
                OtherVulnerabilities = monster.OtherVulnerabilities,
                Resistances = monster.Resistances?.ToTOResist(),
                OtherResistences = monster.OtherResistences,
                Immunities = monster.Immunities?.ToTOImmu(),
                OtherImmunities = monster.OtherImmunities,
                ConditionImmunities = monster.ConditionImmunities?.ToTOCondImmu(),
                Senses = monster.Senses?.ToTOSense(),
                Languages = monster.Languages?.ToTOLang(),
                DifficultyRating = monster.DifficultyRating,
                Traits = monster.Traits.Select(x => x.ToTO()).ToList(),
                Actions = monster.Actions.Select(x => x.ToTO()).ToList(),
                NbrLegendaryActionPerTurn = monster.NbrLegendaryActionPerTurn,
                LegendaryActions = monster.LegendaryActions.Select(x => x.ToTO()).ToList(),
                Reactions = monster.Reactions.Select(x => x.ToTO()).ToList(),
                IsDeleted = monster.IsDeleted
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
             monsterToModify.IsWide = monster.IsWide;
             monsterToModify.Name = monster.Name;
             monsterToModify.Type = monster.Type;
             monsterToModify.Size = monster.Size;
             monsterToModify.Alignment = monster.Alignment;
             monsterToModify.ArmorClass = monster.ArmorClass;
             monsterToModify.Health = monster.Health.ToEF();
             monsterToModify.Speeds = monster.Speeds?.ToEF(monster.Id);
             monsterToModify.Stats = monster.ToEFStat();
             monsterToModify.Skills = monster.ToEFSkill(monster.Id);
             monsterToModify.Vulnerabilities = monster.ToEFVuln(monster.Id);
             monsterToModify.OtherVulnerabilities = monster.OtherVulnerabilities;
             monsterToModify.Resistances = monster.ToEFResist(monster.Id);
             monsterToModify.OtherResistences = monster.OtherResistences;
             monsterToModify.Immunities = monster.ToEFImmu(monster.Id);
             monsterToModify.OtherImmunities = monster.OtherImmunities;
             monsterToModify.ConditionImmunities = monster.ToEFCondImmu(monster.Id);
             monsterToModify.Senses = monster.ToEFSense();
             monsterToModify.Languages = monster.ToEFLang(monster.Id);
             monsterToModify.DifficultyRating = monster.DifficultyRating;
             monsterToModify.Traits = monster.Traits.Select(x => x.ToEF()).ToList();
             monsterToModify.Actions = monster.Actions.Select(x => x.ToEF()).ToList();
             monsterToModify.NbrLegendaryActionPerTurn = monster.NbrLegendaryActionPerTurn;
             monsterToModify.LegendaryActions = monster.LegendaryActions.Select(x => x.ToEF()).ToList();
             monsterToModify.Reactions = monster.Reactions.Select(x => x.ToEF()).ToList();
             monsterToModify.IsDeleted = monster.IsDeleted;

            return monsterToModify;
        }
    }
}
