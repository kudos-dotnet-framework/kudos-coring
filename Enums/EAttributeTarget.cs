using Kudos.Coring.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kudos.Coring.Enums
{
    [Flags]
    public enum EAttributeTarget
    {
        Class = CBinaryFlag._0,
        Member = CBinaryFlag._1
    }
}