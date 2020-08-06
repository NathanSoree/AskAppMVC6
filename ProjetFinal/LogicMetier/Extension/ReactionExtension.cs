using Common.TransferObjects;
using LogicMetier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicMetier.Extension
{
    public static class ReactionExtension
    {
        public static Reaction ToDomain(this ReactionTO reactionTO)
        {
            return new Reaction
            {
                Name = reactionTO.Name,
                Description = reactionTO.Description
            };
        }
        public static ReactionTO ToTO(this Reaction reaction)
        {
            return new ReactionTO
            {
                Name = reaction.Name,
                Description = reaction.Description
            };
        }
    }
}
