using Kudos.Coring.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudos.Coring.Enums
{
    [Flags]
    public enum EDictionaryTryGetValueResult
    {
        NullKey = CBinaryFlag._0,
        KeyNotExists = CBinaryFlag._1,
        KeyExists = CBinaryFlag._2
    }
}
