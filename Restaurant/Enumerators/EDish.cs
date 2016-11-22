using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum EDish
    {
        [Description("Schabowy z frytkami, ryżem lub ziemniakami")]
        Porkchop = 0,
        [Description("Ryba z frytkami")]
        Fish = 1,
        [Description("Placek po węgiersku")]
        Pie = 2
    }
}
