using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Common.Exceptions
{
    public class MonsterNotValidException:Exception
    {
        public MonsterNotValidException():base()
        {
            
        }

        public MonsterNotValidException(string message):base(message)
        {

        }
    }
}
