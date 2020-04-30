using System;
using System.Collections.Generic;
using System.Text;

namespace PersonPrototypeExample.People
{
    public abstract class Prototype
    {
        public abstract Prototype ShallowCopy();
        public abstract Prototype DeepCopy();
        public abstract void PrintDetails();
    }
}
