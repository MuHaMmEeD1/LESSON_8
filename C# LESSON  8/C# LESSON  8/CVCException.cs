using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_8
{
    public class CVCException : Exception
    {

        public override string Message => "CVC yanliz reqem ola boiler ve 3 reqemli olmalidi ve 100-999 arasinda olmalidi";

    }
}