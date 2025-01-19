using System;
using System.Linq.Expressions;
using Kudos.Coring.Constants;
using Kudos.Coring.Utils.Collections;

namespace Kudos.Coring.Utils.Expressions
{
	public static class LambdaExpressionUtils
    {
        #region public static LambdaExpression? Create(...)

        public static LambdaExpression? Create() { return Create(CExpression.Empty, null, null); }
        public static LambdaExpression? Create(Expression? exp) { return Create(exp, null, null); }
        public static LambdaExpression? Create(ParameterExpression? pe, params ParameterExpression[]? pea) { return Create(CExpression.Empty, pe, pea); }
        public static LambdaExpression? Create(Expression? exp, ParameterExpression? pe, params ParameterExpression[]? pea)
        {
            if (exp != null) try { return Expression.Lambda(exp, ArrayUtils.Append(CType.ParameterExpression, pe, pea) as ParameterExpression[]); } catch { }
            return null;
        }

        #endregion

        #region public static LambdaExpression? Parse(...)

        public static LambdaExpression? Parse(Expression? exp)
		{
            if(exp != null) try { return Expression.Lambda(exp); } catch { }
            return null;
        }

        #endregion

        #region public static Delegate? Compile(...)

        public static Delegate? Compile(LambdaExpression? lexp)
        {
            if (lexp != null) try { return lexp.Compile(); } catch { }
            return null;
        }

        #endregion

        #region public static Object? DynamicInvoke(...)

        public static Object? DynamicInvoke(LambdaExpression? lexp, params Object?[]? oa)
        {
            return DelegateUtils.DynamicInvoke(Compile(lexp), oa);
        }

        #endregion
    }
}