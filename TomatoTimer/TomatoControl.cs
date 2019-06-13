using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTimer
{
    class TomatoControl
    {
        private Tomato currentTomato;
        private Tomatobase tomatoBase; // database of successfully completed tomatoes

        public TomatoControl()
        {
            currentTomato.tomatoType = TomatoType.Tomato; // default is Tomato
        }

        public void UpdateTomatoType(TomatoType tType)
        {
            tomatoType = tType;
        }

    }
}
