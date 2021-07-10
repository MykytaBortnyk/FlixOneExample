using FlixOne.InventoryManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    internal class QuitCommand : InventoryCommand
    {
        public QuitCommand(IUserInterface userInterface) :
            base(commandIsTerminating: true, userInteface: userInterface) { }
        internal override bool InternalCommand()
        {
            Interface.WriteMessage("Thank you for using FlixOne Inventory Management System");
            return true;
        }
    }
}
