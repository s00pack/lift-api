using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiftApi.Models
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserInfo> Users { get; set; }
    }
}