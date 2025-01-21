using System;
using System.Collections.Generic;
using Kudos.Coring.Constants;

namespace Kudos.Coring.Utils.Collections
{
    public static class HashSetUtils
    {
        public static Exception? IntersectWith<T>(HashSet<T>? hs, IEnumerable<T>? enm)
        {
            if (hs == null || enm == null) return CException.ArgumentNullException;
            hs.IntersectWith(enm); return null;
        }

        public static Exception? UnionWith<T>(HashSet<T>? hs, IEnumerable<T>? enm)
        {
            if (hs == null || enm == null) return CException.ArgumentNullException;
            hs.UnionWith(enm); return null;
        }

        public static Exception? ExceptWith<T>(HashSet<T>? hs, IEnumerable<T>? enm)
        {
            if (hs == null || enm == null) return CException.ArgumentNullException;
            hs.ExceptWith(enm); return null;
        }

        public static Exception? SymmetricExceptWith<T>(HashSet<T>? hs, IEnumerable<T>? enm)
        {
            if (hs == null || enm == null) return CException.ArgumentNullException;
            hs.SymmetricExceptWith(enm); return null;
        }
    }
}