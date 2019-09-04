using System;
using System.Collections.Generic;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<UserData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserData> User { get; set; }
    }
}
