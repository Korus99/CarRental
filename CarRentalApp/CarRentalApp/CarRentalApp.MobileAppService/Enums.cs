using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.MobileAppService
{
    public static class Enums
    {
        public enum UserTypes
        {
            Noone = 0,
            Maintainer = 50,
            User = 100,
            Admin = 9999
        }
    }
}
