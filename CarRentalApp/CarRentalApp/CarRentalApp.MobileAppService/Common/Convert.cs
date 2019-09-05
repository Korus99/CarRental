using CarRentalApp.MobileAppService.DataModels;

namespace CarRentalApp.MobileAppService.Common
{
    public static class Convert
    {
        public static VehicleData ToDataModel(Models.Vehicle vehicle)
        {
            return new VehicleData()
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Make = vehicle.Make,
                License = vehicle.License,
                Location = vehicle.Location,
                Mileage = vehicle.Mileage,
                Removed = vehicle.Removed,
                State = vehicle.State,
                Vin = vehicle.VIN
            };
        }

        public static Models.Vehicle FromDataModel(VehicleData vehicle)
        {
            return new Models.Vehicle()
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Make = vehicle.Make,
                License = vehicle.License,
                Location = vehicle.Location,
                Mileage = vehicle.Mileage,
                Removed = vehicle.Removed,
                State = vehicle.State,
                VIN = vehicle.Vin
            };
        }

        public static UserData ToDataModel(Models.User user)
        {
            return new UserData()
            {
                Id = user.Id,
                Brand = user.Brand,
                License = user.License,
                Make = user.Make,
                Name = user.Name,
                State = user.State,
                UserType = (int)user.UserType
            };
        }

        public static Models.User FromDataModel(UserData user)
        {
            return new Models.User()
            {
                Id = user.Id,
                Brand = user.Brand,
                License = user.License,
                Make = user.Make,
                Name = user.Name,
                State = user.State,
                UserType = (Enums.UserTypes)user.UserType
            };
        }
    }
}
