using System;
using System.Linq.Expressions;

namespace Kudos.Coring.Utils.Expressions
{
    public static class ParameterExpressionUtils
    {
        #region public static ParameterExpression? Create<...>(...)

        public static ParameterExpression? Create<T>() { return Create(typeof(T)); }
        public static ParameterExpression? Create(Type? t)
        {
            if (t != null) try { return Expression.Parameter(t); } catch { }
            return null;
        }

        #endregion
    }
}

