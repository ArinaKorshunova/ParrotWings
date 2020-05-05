using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ParrotWings.Core.Models
{
    public class User : BaseModel
    {
        public User()
        {
            Accounts = new Collection<Account>();
        }

        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
