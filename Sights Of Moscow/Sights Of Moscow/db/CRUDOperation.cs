using Sights_Of_Moscow.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sights_Of_Moscow.db
{
    public class CRUDOperation
    {
        readonly SQLiteConnection db;
        public CRUDOperation(string databasePath)
        {
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Client>();
        }
        public IEnumerable<Client> GetClients()
        {
            return db.Table<Client>();
        }

        public int SaveClient(Client projectModel)
        {
            return db.Insert(projectModel);
        }
    }
}