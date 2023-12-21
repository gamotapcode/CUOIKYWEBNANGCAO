using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class MenuForm
{
    public decimal IdMenuForm { get; set; }

    public string? MenuFormName { get; set; }

    public string? MenuFormUrl { get; set; }

    public string? Mota { get; set; }

    public byte? SortParent { get; set; }

    public byte? Sort { get; set; }

    public decimal? IdMenuFormParent { get; set; }

    public bool? DanhMuc { get; set; }

    public bool? Visible { get; set; }

    public virtual MenuForm? IdMenuFormParentNavigation { get; set; }

    public virtual ICollection<MenuForm> InverseIdMenuFormParentNavigation { get; set; } = new List<MenuForm>();

    public virtual ICollection<GroupUserRelationshipUser> GroupUserRelationshipUsers { get; set; } = new List<GroupUserRelationshipUser>();

    public virtual ICollection<Application> IdApplications { get; set; } = new List<Application>();
}
