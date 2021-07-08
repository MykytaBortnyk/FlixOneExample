using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    public class QuitCommand : InventoryCommand
    {
        public QuitCommand() : base(true) { }
        internal override bool InternalCommand()
        {
            Console.WriteLine("Thank you for using FlixOne Inventory Management System");

            return true;
        }
    }
}
