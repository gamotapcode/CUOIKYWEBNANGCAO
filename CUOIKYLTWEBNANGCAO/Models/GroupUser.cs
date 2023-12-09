using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class GroupUser
    {
        public GroupUser()
        {
            GroupUserRelationshipUsers = new HashSet<GroupUserRelationshipUser>();
        }

        public decimal IdGroup { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GroupUserRelationshipUser> GroupUserRelationshipUsers { get; set; }
    }
}
