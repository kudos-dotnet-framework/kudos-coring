using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Kudos.Coring.Reflecting.Types
{
    public sealed class Instruction
    {
        public readonly Object? Info;
        public readonly OpCode KeyOpCode;
        public readonly OpCode[] ValueOpCodes;

        internal Instruction(ref Object? o, ref OpCode? oc, ref List<OpCode> l)
        {
            Info = o;
            KeyOpCode = oc.Value;
            ValueOpCodes = l.ToArray();
        }
    }
}