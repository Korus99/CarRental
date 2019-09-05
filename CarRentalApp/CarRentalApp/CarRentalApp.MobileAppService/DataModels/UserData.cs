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
        public string Brand { get; set; }
        public string Make { get; set; }
        public string License { get; set; }
        public string State { get; set; }
        public int UserType { get; set; }

        public virtual UserType UserTypeNavigation { get; set; }
        public virtual ICollection<AvailabilityData> Availability { get; set; }
        public virtual ICollection<MaintenanceData> Maintenance { get; set; }
    }
}
