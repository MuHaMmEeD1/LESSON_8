using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_8
{
    public class PANException : Exception
    {

        public override string Message => "PAN yanliz 16 reqemnen ve yanliz reqemlerden ola biler";

    }
}