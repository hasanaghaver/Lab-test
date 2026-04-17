using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.Models
{
    public class UserService
    {
        IEnumerable<User> _users {  get; set; }= new List<User>();
        Dictionary<string, string> _signedUsers = new Dictionary<string, string>();
        public void Register (User user)
        {
            _users.Append(user);
        }
        public void Login(string email, string password)
        {

        }

    }
}
