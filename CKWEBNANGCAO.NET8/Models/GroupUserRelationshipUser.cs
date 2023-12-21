using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class GroupUserRelationshipUser
{
    public decimal PartyId { get; set; }

    public decimal IdGroup { get; set; }

    public virtual GroupUser IdGroupNavigation { get; set; } = null!;

    public virtual Party Party { get; set; } = null!;

    public virtual ICollection<MenuForm> IdMenuForms { get; set; } = new List<MenuForm>();
}
