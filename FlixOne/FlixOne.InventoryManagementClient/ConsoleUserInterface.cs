using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagementClient
{
    public class ConsoleUserInterface
    {
        public string ReadValue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            return Console.ReadLine();
        }
        public void WriteMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        public void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
        }
    }
}
