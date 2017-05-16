using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTLibrary.MTContext;
using MTLibrary.MTEntity;
using MTLibrary.MTInterface;

namespace MTLibrary.MTRepository
{
    public class UserReposity : IUser
    {
        private readonly MTDbContext _db = new MTDbContext();
        public List<User> GetList()
        {
            //return _db.Users.ToList();
             return new List<User>() { new User() {Age = 10,Id = "1",UsersName = "abc"}, new User() { Age = 10, Id = "2", UsersName = "abc2" } };

        }
    }
}
