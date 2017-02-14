using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MMG_Soft_MailSender.Class
{
    class clsPublic
    {
       public enum enStatus
        {
           Unsend=0,
           Send=1,
           Err=2,
           Block
        }

       public bool udfEmailValidator(string inp)
       {           
           string reg = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
            + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

           if (!Regex.IsMatch(inp, reg))
           {
               return false;
           }
           else
           {
               return true;
           }
       }
    }
}
