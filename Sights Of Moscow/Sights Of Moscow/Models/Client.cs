using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sights_Of_Moscow.Models
{
    [Table("Client")]
    public class Client
    {
        public Client(string login , string email, string password)
        {
            Nickname = login;
            Email = email;
            Password = password;
        }

        public Client()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Nickname { get; set; }
        public string Email { get; set; }
        [Unique]
        public string Password { get; set; }


    }
}
