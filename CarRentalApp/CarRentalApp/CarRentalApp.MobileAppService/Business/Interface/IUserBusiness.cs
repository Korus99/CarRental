using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IUserBusiness
    {
        void Add(User user);
        void Update(User user);
        User Remove(int id);
        User Get(int id);
        IEnumerable<User> GetAll();
    }
}
