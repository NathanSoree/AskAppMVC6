using Common.TransferObjects;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Extension
{
    public static class TraitsExtension
    {
        public static Traits ToDomain(this TraitsTO traitsTO)
        {
            return new Traits
            {
                Name = traitsTO.Name,
                Description = traitsTO.Description
            };
        }
        public static TraitsTO ToTO(this Traits traits)
        {
            return new TraitsTO
            {
                Name = traits.Name,
                Description = traits.Description
            };
        }
    }
}
