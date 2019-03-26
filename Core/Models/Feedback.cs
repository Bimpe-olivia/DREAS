using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Feedback : BaseModel
    {
        public Guid clientID;
        public Guid serviceProviderID;
        public Property Property { get; set; }
        public Guid PropertyID { get; set; }

        public User User { get; set; }
        public Guid UserID { get; set; }

        public string FeedbackMessage { get; set; }

        private RoleType roleTypes;
        public List<Role> Roles { get; set; }


     
    }
}
