﻿using System;
using System.Windows.Forms;
using Trero.ClientBase;
using Trero.ClientBase.FaketernalBase;
using Trero.ClientBase.KeyBase;
using Trero.ClientBase.VersionBase;

namespace Trero.Modules
{
    class Tower : Module
    {
        public Tower() : base("Tower", (char)0x07, "Other") { } // Not defined
        public override void onTick()
        {
            
        }
    }
}
