using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum  ETable
    {
        [Description("Stolik nr 1")]
        Table_No1 = 0,
        [Description("Stolik nr 2")]
        Table_No2 = 1,
        [Description("Stolik nr 3")]
        Table_No3 = 2,
        [Description("Stolik nr 4")]
        Table_No4 = 3
    }
}
