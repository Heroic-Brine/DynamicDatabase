using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicDatabase.Interfaces
{
    interface IHashing
    {
        string GenerateHash(string input);
    }
}
