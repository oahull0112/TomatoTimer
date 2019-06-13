using System;
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
    }
}
