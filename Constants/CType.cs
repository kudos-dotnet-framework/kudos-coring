using Kudos.Coring.Types;
using Kudos.Coring.Types.TimeStamps.UnixTimeStamp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.Json;

namespace Kudos.Coring.Constants
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    public static class CType
    {
        public static readonly Type
            Action = fastTypeOf<Action>.Value,
            Delegate = fastTypeOf<Delegate>.Value,
            Object = fastTypeOf<Object>.Value,
            NullableInt16 = fastTypeOf<Int16?>.Value,
            Int16 = fastTypeOf<Int16>.Value,
            NullableInt32 = fastTypeOf<Int32?>.Value,
            Int32 = fastTypeOf<Int32>.Value,
            NullableInt64 = fastTypeOf<Int64?>.Value,
            Int64 = fastTypeOf<Int64>.Value,
            NullableInt128 = fastTypeOf<Int128?>.Value,
            Int128 = fastTypeOf<Int128>.Value,
            NullableUInt16 = fastTypeOf<UInt16?>.Value,
            UInt16 = fastTypeOf<UInt16>.Value,
            NullableUInt32 = fastTypeOf<UInt32?>.Value,
            UInt32 = fastTypeOf<UInt32>.Value,
            NullableUInt64 = fastTypeOf<UInt64?>.Value,
            UInt64 = fastTypeOf<UInt64>.Value,
            NullableUInt128 = fastTypeOf<UInt128?>.Value,
            UInt128 = fastTypeOf<UInt128>.Value,
            NullableSingle = fastTypeOf<Single?>.Value,
            Single = fastTypeOf<Single>.Value,
            NullableDouble = fastTypeOf<Double?>.Value,
            Double = fastTypeOf<Double>.Value,
            NullableDecimal = fastTypeOf<Decimal?>.Value,
            Decimal = fastTypeOf<Decimal>.Value,
            NullableChar = fastTypeOf<Char?>.Value,
            Byte = fastTypeOf<Byte>.Value,
            NullableByte = fastTypeOf<Byte?>.Value,
            Char = fastTypeOf<Char>.Value,
            String = fastTypeOf<String>.Value,
            NullableBoolean = fastTypeOf<Boolean?>.Value,
            Boolean = fastTypeOf<Boolean>.Value,
            DateTime = fastTypeOf<DateTime>.Value,
            NullableDateTime = fastTypeOf<DateTime?>.Value,
            Enum = fastTypeOf<Enum>.Value,
            BytesArray = fastTypeOf<Byte[]>.Value,
            MemberInfo = fastTypeOf<MemberInfo>.Value,
            FieldInfo = fastTypeOf<FieldInfo>.Value,
            PropertyInfo = fastTypeOf<PropertyInfo>.Value,
            MethodInfo = fastTypeOf<MethodInfo>.Value,
            ConstructorInfo = fastTypeOf<ConstructorInfo>.Value,
            OpCode = fastTypeOf<OpCode>.Value,
            OpCodes = fastTypeOf<OpCodes>.Value,
            Type = fastTypeOf<Type>.Value,
            JsonElement = fastTypeOf<JsonElement>.Value,
            UnixTimeStamp = fastTypeOf<UnixTimeStamp>.Value,
            Array = fastTypeOf<Array>.Value,
            IList = fastTypeOf<IList>.Value,
            List = typeof(List<>),
            LambdaExpression = fastTypeOf<LambdaExpression>.Value,
            ParameterExpression = fastTypeOf<ParameterExpression>.Value;
    }
}