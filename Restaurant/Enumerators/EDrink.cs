using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum EDrink
    {
        [Description("Kawa")]
        Coffee = 0,
        [Description("Herbata")]
        Tea = 1,
        [Description("Cola")]
        Cola = 2
    }
}
