using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON__8
{
    public class YanlisPINException : Exception
    {
        public override string Message => "!!!bele bir user yoxdu!!!";
    }
}
