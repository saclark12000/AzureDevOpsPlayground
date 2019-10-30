using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Entities
{
    public class Users
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserFn { get; set; }
        public string UserLn { get; set; }
    }
}
