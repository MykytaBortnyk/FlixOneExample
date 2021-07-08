using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    internal class HelpCommand : NonTerminatingCommand
    {
        internal override bool InternalCommand()
        {
            Console.WriteLine("USAGE:");
            Console.WriteLine("\taddinventory (a)");

            Console.WriteLine("Examples:");

            return true;
        }
    }
}
