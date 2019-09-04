using System.Collections.Generic;
using CarRentalApp.MobileAppService.Models;

namespace CarRentalApp.MobileAppService.Repository.Interface
{
    public interface IUserRepository
    {
        void Add(User item);
        void Update(User item);
        Vehicle Remove(int key);
        Vehicle Get(int id);
        IEnumerable<User> GetAll();
    }
}
