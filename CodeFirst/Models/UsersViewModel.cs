using System;

namespace CodeFirst.Models
{
    public class UsersViewModel
    {
        public UsersViewModel(){}
        public Guid UserId { get; set; }
        public string UserFn { get; set; }
        public string UserLn { get; set; }
    }
}
