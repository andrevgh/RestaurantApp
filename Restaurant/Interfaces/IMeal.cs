using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    interface IMeal
    {
        int Id { get; set; }
        double Price { get;  }
        int Amount { get; set; }
    }
}
