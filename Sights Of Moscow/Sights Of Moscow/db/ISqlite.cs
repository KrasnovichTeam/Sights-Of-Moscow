using System;
using System.Collections.Generic;
using System.Text;

namespace Sights_Of_Moscow.db
{
    public interface ISqlite
    {
        string GetDatabasePath(string filename);
    }
}
