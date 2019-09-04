using System;
using System.Collections.Generic;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class UserData
    {
        public UserData()
        {
            Availability = new HashSet<AvailabilityData>();
            Maintenance = new HashSet<MaintenanceData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Brand { get; set; }
        public byte[] Make { get; set; }
        public byte[] License { get; set; }
        public byte[] State { get; set; }
        public int UserType { get; set; }

        public virtual UserType UserTypeNavigation { get; set; }
        public virtual ICollection<AvailabilityData> Availability { get; set; }
        public virtual ICollection<MaintenanceData> Maintenance { get; set; }
    }
}
