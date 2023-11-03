using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }

        public User(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
