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
                Alignment = monsterTO.Alignment,
                ArmorClass = monsterTO.ArmorClass,
                Health = monsterTO.Health.ToDomain(),
                Speeds = monsterTO.Speeds,
                Stats = monsterTO.Stats,
                Saving = monsterTO.Saving,
                Skills = monsterTO.Skills,
                Vulnerabilities = monsterTO.Vulnerabilities,
                OtherVulnerabilities = monsterTO.OtherVulnerabilities,
                Resistances = monsterTO.Resistances,
                OtherResistences = monsterTO.OtherResistences,
                Immunities = monsterTO.Immunities,
                OtherImmunities = monsterTO.OtherImmunities,
                ConditionImmunities = monsterTO.ConditionImmunities,
                Senses = monsterTO.Senses,
                Languages = monsterTO.Languages,
                DifficultyRating = monsterTO.DifficultyRating,
                Traits = monsterTO.Traits.Select(x => x.ToDomain()).ToList(),
                Actions = monsterTO.Actions.Select(x => x.ToDomain()).ToList(),
                NbrLegendaryActionPerTurn = monsterTO.NbrLegendaryActionPerTurn,
                LegendaryActions = monsterTO.LegendaryActions.Select(x => x.ToDomain()).ToList(),
                Reactions = monsterTO.Reactions.Select(x => x.ToDomain()).ToList(),
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
                Alignment = monster.Alignment,
                ArmorClass = monster.ArmorClass,
                Health = monster.Health.ToTO(),
                Speeds = monster.Speeds,
                Stats = monster.Stats,
                Saving = monster.Saving,
                Skills = monster.Skills,
                Vulnerabilities = monster.Vulnerabilities,
                OtherVulnerabilities = monster.OtherVulnerabilities,
                Resistances = monster.Resistances,
                OtherResistences = monster.OtherResistences,
                Immunities = monster.Immunities,
                OtherImmunities = monster.OtherImmunities,
                ConditionImmunities = monster.ConditionImmunities,
                Senses = monster.Senses,
                Languages = monster.Languages,
                DifficultyRating = monster.DifficultyRating,
                Traits = monster.Traits.Select(x => x.ToTO()).ToList(),
                Actions = monster.Actions.Select(x => x.ToTO()).ToList(),
                NbrLegendaryActionPerTurn = monster.NbrLegendaryActionPerTurn,
                LegendaryActions = monster.LegendaryActions.Select(x => x.ToTO()).ToList(),
                Reactions = monster.Reactions.Select(x => x.ToTO()).ToList(),
                IsDeleted = monster.IsDeleted
            };
        }
        
    }
}
