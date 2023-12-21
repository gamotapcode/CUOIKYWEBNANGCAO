using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class GroupUser
{
    public decimal IdGroup { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<GroupUserRelationshipUser> GroupUserRelationshipUsers { get; set; } = new List<GroupUserRelationshipUser>();
}
