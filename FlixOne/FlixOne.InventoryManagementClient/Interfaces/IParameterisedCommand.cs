using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.Interfaces.InventoryManagementClient
{
    public interface IParameterisedCommand
    {
        bool GetParameters();
    }
}
