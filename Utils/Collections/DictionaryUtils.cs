using System;
using System.Collections.Generic;
using Kudos.Coring.Types;

namespace Kudos.Coring.Utils.Collections
{
    public static class DictionaryUtils
    {
        public static SmartResult<Boolean?> Remove<K, V>(Dictionary<K, V>? d, K? k)
        {
            if (d == null || k == null) return SmartResult<bool?>.ArgumentNullException;
            try { return new SmartResult<bool?>(d.Remove(k)); }
            catch (Exception exc) { return new SmartResult<bool?>(exc); }
        }
    }
}

