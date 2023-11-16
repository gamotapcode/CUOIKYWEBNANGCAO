using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class GroupUserRelationshipUser
    {
        public GroupUserRelationshipUser()
        {
            GroupRelationshipMenuForms = new HashSet<GroupRelationshipMenuForm>();
        }

        public decimal PartyId { get; set; }
        public decimal IdGroup { get; set; }

        public virtual GroupUser IdGroupNavigation { get; set; }
        public virtual Party Party { get; set; }
        public virtual ICollection<GroupRelationshipMenuForm> GroupRelationshipMenuForms { get; set; }
    }
}
