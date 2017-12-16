using Kabals.DAL.Entity;
using Kabals.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kabals.Core
{
    public class UserService
    {
        public bool AddUser()
        {
            return true;
        }

        public List<Connection> GetUserConnections()
        {
            return new List<Connection>();
        }

        public bool AddConnection()
        {
            return true;
        }

        public User GetUser(long userId)
        {
            return new UserRepository().GetUser(userId);
        }
    }
}