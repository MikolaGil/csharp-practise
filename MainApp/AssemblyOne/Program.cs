using System;

namespace AssemblyOne
{
    public class AssemblyOneType
    {
        private int privateInt = 1;
        public string publicString = "Hello";
        protected bool protectedBool = true;
        internal const string InternalConst = "Nick";
        protected internal int protectedInternalVal = 2020;
        protected private char protectedPrivate()
        {
            return 'Z';
        }

    }
}
