﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoTimer
{
    class Tomato
    {
        private TomatoType tomatoType;
        private DateTime createDate;
        private DateTime endDate;

        public Tomato(TomatoType tType)
        {
            tomatoType = tType;
            createDate = DateTime.Now;
        }

        public void SetTomatoType(TomatoType tType)
        {
            tomatoType = tType;
        }

        public void naturalDeath()
        {
            // tomato died because timer ran out
            endDate = DateTime.Now;
        }

        public void EatTomato()
        {
            // tomato died because user chose a new timer type
            tomatoType = TomatoType.Eaten;
        }
    }
}
