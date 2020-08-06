using Common.Enumerations;
using Common.TransferObjects;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class ActionExtensionDAL
    {
        public static ActionEF ToEF(this ActionTO actionTO) 
        {
            return new ActionEF
            {
                Name = actionTO.Name,
                Description = actionTO.Description,
                IsAttack = actionTO.IsAttack,
                Attack = actionTO.Attack.ToEF()
            };
        }
        public static ActionTO ToTO(this ActionEF action)
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
