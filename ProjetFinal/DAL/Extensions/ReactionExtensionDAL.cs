using Common.TransferObjects;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    public static class ReactionExtensionDAL
    {
        public static ReactionEF ToEF(this ReactionTO reactionTO)
        {
            return new ReactionEF
            {
                Name = reactionTO.Name,
                Description = reactionTO.Description
            };
        }
        public static ReactionTO ToTO(this ReactionEF reaction)
        {
            return new ReactionTO
            {
                Name = reaction.Name,
                Description = reaction.Description
            };
        }
    }
}
