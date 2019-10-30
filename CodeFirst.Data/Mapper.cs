using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Data
{
    class Mapper
    {
        public static Entities.Users MapUsers(Library.Models.Users user)
        {
            return new Entities.Users
            {
                UserId = user.UserId,
                UserFn = user.UserFn,
                UserLn = user.UserLn
            };
        }

        public static Library.Models.Users MapUsers(Entities.Users user)
        {
            return new Library.Models.Users
            {
                UserId = user.UserId,
                UserFn = user.UserFn,
                UserLn = user.UserLn
            };
        }
    }
}
