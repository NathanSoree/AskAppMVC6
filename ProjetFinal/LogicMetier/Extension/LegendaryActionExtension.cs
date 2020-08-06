using Common.TransferObjects;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Extension
{
    public static class LegendaryActionExtension
    {
        public static LegendaryAction ToDomain(this LegendaryActionTO legendaryActionTO)
        {
            return new LegendaryAction
            {
                Name = legendaryActionTO.Name,
                Cost = legendaryActionTO.Cost,
                Description = legendaryActionTO.Description
            };
        }
        public static LegendaryActionTO ToTO(this LegendaryAction legendaryAction)
        {
            return new LegendaryActionTO
            {
                Name = legendaryAction.Name,
                Cost = legendaryAction.Cost,
                Description = legendaryAction.Description
            };
        }
    }
}
