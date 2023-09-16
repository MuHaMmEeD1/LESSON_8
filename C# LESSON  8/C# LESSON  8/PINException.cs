using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_8
{
    public class PINException : Exception
    {
        public override string Message => "PIN yanliz reqem oila biler ve 4 reqemli ola biler";

    }

}