using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class TraitsExtensionDAL
    {
        public static TraitsEF ToEF(this TraitsTO traitsTO)
        {
            return new TraitsEF
            {
                Name = traitsTO.Name,
                Description = traitsTO.Description
            };
        }
        public static TraitsTO ToTO(this TraitsEF traits)
        {
            return new TraitsTO
            {
                Name = traits.Name,
                Description = traits.Description
            };
        }
    }
}
