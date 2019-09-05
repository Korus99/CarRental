using CarRentalApp.MobileAppService.Common;

namespace CarRentalApp.MobileAppService.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Make { get; set; }

        public string License { get; set; }

        public string State { get; set; }

        public Enums.UserTypes UserType { get; set; }

        public string Password { get; set; }
    }
}
