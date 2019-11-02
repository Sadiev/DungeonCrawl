using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    interface IInventory
    {
        string Name { get; set; }
        string Description { get; set; }
        decimal Cost { get; set; }
    }
}
