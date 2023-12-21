using System;
using System.Collections.Generic;

namespace CKWEBNANGCAO.NET8.Models;

public partial class GenderType
{
    public decimal GenderTypeId { get; set; }

    public string GenderTypeName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Gender> Genders { get; set; } = new List<Gender>();
}
