using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IUserBusiness
    {
        void Add(User item);
        void Update(User item);
        User Remove(int key);
        User Get(int id);
        IEnumerable<User> GetAll();
    }
}
