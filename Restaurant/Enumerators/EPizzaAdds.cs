using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum EPizzaAdds
    {
        [Description("Podwójny ser")]
        DoubleCheese = 0,
        [Description("Salami")]
        Salami = 1,
        [Description("Szynka")]
        Ham = 2,
        [Description("Pieczarki")]
        Mushrooms = 3
    }
}
