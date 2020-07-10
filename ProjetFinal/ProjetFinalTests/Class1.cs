using Common.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinalTests
{
    static class testHelper
    {
        public static MonsterTO testMonster(int id)
        {
            return new MonsterTO 
            {
                Id=id,
                Author="trololo"
            };
        }
    }
}
