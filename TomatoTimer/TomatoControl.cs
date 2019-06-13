﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTimer
{
    class TomatoControl
    {
        private TomatoType tomatoType;

        public TomatoControl()
        {
            tomatoType = TomatoType.Tomato; // default is Tomato
        }

        public void UpdateTomatoType(TomatoType tType)
        {
            tomatoType = tType;
        }

    }
}
