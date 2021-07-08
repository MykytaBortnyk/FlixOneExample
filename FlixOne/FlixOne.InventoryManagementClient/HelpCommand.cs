using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    public class HelpCommand : InventoryCommand
    {
        public HelpCommand() : base(false) { }
        internal override bool InternalCommand()
        {
            Console.WriteLine("USAGE:");
            Console.WriteLine("\taddinventory (a)");

            Console.WriteLine("Examples:");

            return true;
        }
    }
}
