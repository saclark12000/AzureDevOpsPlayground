using System;
using System.Collections.Generic;
using System.Text;
using CodeFirst.Library.Interfaces;
using CodeFirst.Data.Entities;

namespace CodeFirst.Data.Repository
{
    public class UsersRepository : IUsersRepository
    {

        private readonly CodeFirstContext _dbContext;

        public UsersRepository(CodeFirstContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public CodeFirst.Library.Models.Users CreateUser(string fname, string lname) {

            Users createdUser = new Users()
            {
                UserId = Guid.NewGuid(),
                UserFn = fname,
                UserLn = lname
            };

            _dbContext.Users.Add(createdUser);
            _dbContext.SaveChanges();
            
            return Mapper.MapUsers(createdUser);
        }

        public IEnumerable<Library.Models.Users> GetAllUsers()
        {
            IEnumerable<Users> allUsers = _dbContext.Users;
            List<Library.Models.Users> returnAllUsers = new List<Library.Models.Users>();

            foreach (var user in allUsers)
            {
                returnAllUsers.Add(Mapper.MapUsers(user));
            }
            
            return returnAllUsers;
        
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UsersRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
