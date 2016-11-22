using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum ESoup
    {
        [Description("Zupa pomidorowa")]
        TomatoSoup = 0,
        [Description("Rosół")]
        Broth = 1
    }
}
