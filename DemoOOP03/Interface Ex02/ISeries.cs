﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Interface_Ex02
{
    internal interface ISeries
    {
        int Current { get; set; }

        void Next();

        void Reset();   
    }
}
