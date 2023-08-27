using System;

//ref link:https://www.youtube.com/watch?v=m8H7Ij0_JWo&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=17
//

class MainClass
{
    static void Main()
    {
        //int i = 5;
        //long myLong = i;

        object o = 5;   // boxing
        //long myLong = (long)o;  // error unbox not exact type
        long myLong = (int)o;  // exact type unboxing
    }
}