using Ranta.LogMagic.Common.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Common
{
    internal class Msmq : Msmq<object>
    {
        public Msmq(string path)
            : base(path)
        {

        }
    }
}
