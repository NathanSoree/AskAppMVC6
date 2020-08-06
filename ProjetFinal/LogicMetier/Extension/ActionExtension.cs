using Common.Enumerations;
using Common.TransferObjects;
using LogicMetier.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;
using Action = LogicMetier.Domain.Action;

namespace LogicMetier.Extension
{
    public static class ActionExtension
    {
        public static Action ToDomain(this ActionTO actionTO) 
        {
            return new Action
            {
                Name = actionTO.Name,
                Description = actionTO.Description,
                IsAttack = actionTO.IsAttack,
                Attack = actionTO.Attack.ToDomain()
            };
        }
        public static ActionTO ToTO(this Action action)
        {
            return new ActionTO
            {
                Name = action.Name,
                Description = action.Description,
                IsAttack = action.IsAttack,
                Attack = action.Attack.ToTO()
            };
        }
    }
}
