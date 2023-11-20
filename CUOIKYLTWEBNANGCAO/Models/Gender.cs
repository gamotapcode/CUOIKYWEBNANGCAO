using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class Gender
    {
        public decimal PartyId { get; set; }
        public decimal GenderTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ThruDate { get; set; }

        public virtual GenderType GenderType { get; set; }
    }
}
