using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranta.LogMagic.Common
{
    [Serializable]
    public class MessageBase<T>
    {
        public Guid Guid { get; set; }

        public T Content { get; set; }
    }
}
