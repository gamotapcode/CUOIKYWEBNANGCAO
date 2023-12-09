using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class ApplicationsMenuFormRelation
    {
        public decimal IdMenuForm { get; set; }
        public decimal IdApplication { get; set; }

        public virtual Application IdApplicationNavigation { get; set; }
        public virtual MenuForm IdMenuFormNavigation { get; set; }
    }
}
