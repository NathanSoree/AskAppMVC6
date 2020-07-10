using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Common.Exceptions
{
    

    public class MonsterNotExistingException:Exception
    {
        public MonsterNotExistingException():base()
        {
            
        }

        public MonsterNotExistingException(string message):base(message)
        {

        }
    }
}
