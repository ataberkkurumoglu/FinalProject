using CoreReCap.EntitiesReCap;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesReCap.Concrete
{
    public class Users:IEntityReCap
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
