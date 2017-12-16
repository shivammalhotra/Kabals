using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kabals.DAL.Entity
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }

    public class Connection
    {
        public long ConnectionId { get; set; }
        public long ParentUserId { get; set; }
        public long ChildUserId { get; set; }
        public bool IsAccepted { get; set; }
    }
}