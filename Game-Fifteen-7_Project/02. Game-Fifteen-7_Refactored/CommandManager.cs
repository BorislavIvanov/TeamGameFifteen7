﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFifteenVersionSeven
{
    public class CommandManager
    {
        public void Proceed(ICommand command)
        {
            command.Execute();
        }
    }
}