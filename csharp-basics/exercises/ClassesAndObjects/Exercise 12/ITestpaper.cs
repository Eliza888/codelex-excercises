﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }
}