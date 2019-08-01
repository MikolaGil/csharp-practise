using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        void Main()
        {
            AssemblyOneType getProps = new AssemblyOneType();
            int privateInt = getProps.privateInt;//Private - can call only inside base class
            string test = getProps.publicString;//Public - can call anywhere
            string internalConst = getProps.InternalConst;//Internal - Can use only in the same assembly
            bool protectedBool = ProtectedVal.GetProtectedValueFromBaseClass();//Protected - Can use in the same class, or in a class that is derived from that class
        }
        class ProtectedVal: AssemblyOneType
        {
            public bool GetProtectedValueFromBaseClass()
            {
                ProtectedVal protectedValFromBaseClass = new ProtectedVal();
                bool protectedFromBaseClass = protectedValFromBaseClass.protectedBool;
                char protectedPrivateChar = ProtectedVal.protectedPrivate();//Protected private - Can use only within its declaring assembly, by code in the same class or in a type that is derived from that class
                return protectedFromBaseClass;
            }
        }

        class ProtectedInternal: AssemblyOneType
        {
            static int protectedInternalInt;
            static void GetProtectedInternal()
            {
                var protectedVal = new ProtectedInternal();
                protectedInternalInt = protectedVal.protectedInternalVal; //Protected internal - Can use in the assembly in which it is declared, or from within a derived class in another assembly.
            }
        }
    }
}
