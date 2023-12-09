using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class Application
    {
        public Application()
        {
            ApplicationsMenuFormRelations = new HashSet<ApplicationsMenuFormRelation>();
        }

        public decimal IdApplication { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ApplicationsMenuFormRelation> ApplicationsMenuFormRelations { get; set; }
    }
}
