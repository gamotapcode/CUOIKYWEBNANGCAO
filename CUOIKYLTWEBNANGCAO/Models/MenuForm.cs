using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class MenuForm
    {
        public MenuForm()
        {
            ApplicationsMenuFormRelations = new HashSet<ApplicationsMenuFormRelation>();
            GroupRelationshipMenuForms = new HashSet<GroupRelationshipMenuForm>();
            InverseIdMenuFormParentNavigation = new HashSet<MenuForm>();
        }

        public decimal IdMenuForm { get; set; }
        public string MenuFormName { get; set; }
        public string MenuFormUrl { get; set; }
        public string Mota { get; set; }
        public byte? SortParent { get; set; }
        public byte? Sort { get; set; }
        public decimal? IdMenuFormParent { get; set; }
        public bool? DanhMuc { get; set; }
        public bool? Visible { get; set; }

        public virtual MenuForm IdMenuFormParentNavigation { get; set; }
        public virtual ICollection<ApplicationsMenuFormRelation> ApplicationsMenuFormRelations { get; set; }
        public virtual ICollection<GroupRelationshipMenuForm> GroupRelationshipMenuForms { get; set; }
        public virtual ICollection<MenuForm> InverseIdMenuFormParentNavigation { get; set; }
    }
}
