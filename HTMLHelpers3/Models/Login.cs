using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers3.Models
{
    //The HtmlHelper class provides two extension methods which we can use to generate a password field of <input type=”password”> in an MVC view.
    //These two extension methods are Password() and PasswordFor().
    public class Login
    {
        public int LogiId { get; set; }
            public string LoginName { get; set; }
        public string LoginPassword { get; set; }
    }
}