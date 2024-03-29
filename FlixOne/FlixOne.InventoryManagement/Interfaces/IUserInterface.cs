﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixOne.InventoryManagement.Interfaces
{
    public interface IUserInterface : IReadUserInterface, IWriteUserInterface
    {
    }
    public interface IReadUserInterface
    {
        string ReadValue(string message);
    }
    public interface IWriteUserInterface
    {
        void WriteMessage(string message);
        void WriteWarning(string message);
    }
}
