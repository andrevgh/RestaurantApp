using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum EDishAdds
    {
        [Description("Bar sałatkowy")]
        Salad = 0,
        [Description("Zestaw sosów")]
        Sauce = 1
    }
}
