﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidState.Common
{
    internal class TaskCache
    {
        public static Task<bool> FalseTask = Task.FromResult(false);
    }
}
