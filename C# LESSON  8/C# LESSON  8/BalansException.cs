using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON__8
{
    public class BalansException : Exception
    {
        public override string Message => "Balansda bu qeder pul yoxdu";
    }
}
