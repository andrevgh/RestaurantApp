using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Enumerators
{
    public enum EPizza
    {
        [Description("Margeritta")]
        Margeritta = 0,
        [Description("Vegetariana")]
        Vegetariana = 1,
        [Description("Tosca")]
        Tosca = 2,
        [Description("Venecia")]
        Venecia = 3
    }
}
