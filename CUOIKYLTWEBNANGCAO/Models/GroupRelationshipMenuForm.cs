using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class GroupRelationshipMenuForm
    {
        public decimal PartyId { get; set; }
        public decimal IdGroup { get; set; }
        public decimal IdMenuForm { get; set; }

        public virtual GroupUserRelationshipUser GroupUserRelationshipUser { get; set; }
        public virtual MenuForm IdMenuFormNavigation { get; set; }
    }
}
