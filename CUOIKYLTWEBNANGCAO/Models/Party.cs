using System;
using System.Collections.Generic;

#nullable disable

namespace CUOIKYLTWEBNANGCAO.Models
{
    public partial class Party
    {
        public Party()
        {
            GroupUserRelationshipUsers = new HashSet<GroupUserRelationshipUser>();
            TbHoadons = new HashSet<TbHoadon>();
        }

        public decimal PartyId { get; set; }
        public string TypeOfParty { get; set; }
        public int? DepartmentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UsernameH { get; set; }
        public string PasswordH { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<GroupUserRelationshipUser> GroupUserRelationshipUsers { get; set; }
        public virtual ICollection<TbHoadon> TbHoadons { get; set; }
    }
}
