using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class Application
{
    public decimal IdApplication { get; set; }

    public string? ApplicationName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<MenuForm> IdMenuForms { get; set; } = new List<MenuForm>();
}
