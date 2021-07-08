using FlixOne.Interfaces.InventoryManagementClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    public class AddInventoryCommand : InventoryCommand, IParameterisedCommand
    {
        public string InventoryName { get; private set; }
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
