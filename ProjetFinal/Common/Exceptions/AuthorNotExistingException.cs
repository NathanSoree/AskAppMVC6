using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Common.Exceptions
{
    public class AuthorNotExistingException:Exception
    {
        public AuthorNotExistingException():base()
        {
            
        }

        public AuthorNotExistingException(string message):base(message)
        {

        }
    }
}
