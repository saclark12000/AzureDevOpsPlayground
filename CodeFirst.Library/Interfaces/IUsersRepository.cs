using System;
using System.Collections.Generic;
using System.Text;
using CodeFirst.Library.Models;
namespace CodeFirst.Library.Interfaces
{
    public interface IUsersRepository : IDisposable
    {
        public Users CreateUser(string fname, string lname);

        public IEnumerable<Users> GetAllUsers();
    }
}
