using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class GenderType
    {
        public GenderType()
        {
            Genders = new HashSet<Gender>();
        }

        public decimal GenderTypeId { get; set; }
        public string GenderTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Gender> Genders { get; set; }
    }
}
