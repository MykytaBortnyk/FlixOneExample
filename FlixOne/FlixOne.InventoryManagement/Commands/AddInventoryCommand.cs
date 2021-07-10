using FlixOne.Interfaces.InventoryManagement;
using FlixOne.InventoryManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement
{
    internal class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public string InventoryName { get; private set; }

        internal AddInventoryCommand(IUserInterface userInterface) : base(userInterface) { }

        /// <summary>
        /// AddInventoryCommand requires name
        /// </summary>
        /// <returns></returns>
        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");
            return !string.IsNullOrWhiteSpace(InventoryName);
        }

        internal override bool InternalCommand()
        {
            throw new NotImplementedException();
        }
    }
}
