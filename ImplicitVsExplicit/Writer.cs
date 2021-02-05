﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitVsExplicit
{
    class Writer : IWriterInterface
    {
        public void Write()
        {
            Console.WriteLine("Explicit realization");
        }
        
        void IWriterInterface.Write()
        {
            Console.WriteLine("Implicit realization");
        }
    }
}
