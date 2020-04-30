using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeCompleteExample.People
{
    public abstract class Prototype
    {
        public abstract Prototype DeepCopy();
        public abstract void PrintDetails();
    }
}
