using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class LegendaryActionExtensionDAL
    {
        public static LegendaryActionEF ToEF(this LegendaryActionTO legendaryActionTO)
        {
            return new LegendaryActionEF
            {
                Name = legendaryActionTO.Name,
                Cost = legendaryActionTO.Cost,
                Description = legendaryActionTO.Description
            };
        }
        public static LegendaryActionTO ToTO(this LegendaryActionEF legendaryAction)
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
