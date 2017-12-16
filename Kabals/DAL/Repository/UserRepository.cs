using Kabals.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kabals.DAL.Repository
{
    public class UserRepository
    {
        public User GetUser(long UserId)
        {
            return new User()
            {
                UserId = 100001,
                FirstName = "shivam",
                LastName = "malhotra",
                Email = "malhotra.shivam@gmail.com"
            };
        }

        public List<Connection> GetUserConnections(long UserId)
        {

            return new List<Connection>()
            {
                new Connection() {
                     ConnectionId = 1,
                     ParentUserId = 100001,
                     ChildUserId = 100002,
                     IsAccepted = true
                },
                new Connection() {
                    ConnectionId = 2,
                    ParentUserId = 100001,
                    ChildUserId = 100003,
                    IsAccepted = false
                }
            };
        }

    }
}