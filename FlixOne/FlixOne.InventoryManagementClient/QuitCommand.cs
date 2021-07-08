using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    internal class QuitCommand : InventoryCommand
    {
        internal QuitCommand() : base(true) { }
        internal override bool InternalCommand()
        {
            Console.WriteLine("Thank you for using FlixOne Inventory Management System");

            return true;
        }
    }
}
