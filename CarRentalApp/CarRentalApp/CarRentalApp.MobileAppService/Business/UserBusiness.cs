using System.Collections.Generic;
using System.Linq;
using CarRentalApp.MobileAppService.Common;
using CarRentalApp.MobileAppService.DataModels;
using CarRentalApp.MobileAppService.Models;
using CarRentalApp.MobileAppService.Repository.Interface;

namespace CarRentalApp.MobileAppService.Business
{
    public class UserBusiness : IUserBusiness
    {
        public UserBusiness()
        {

        }

        public IEnumerable<User> GetAll()
        {
            using (var context = new CarRentalContext())
            {
                var users = context.User.ToList();
                foreach (var user in users)
                {
                    yield return Convert.FromDataModel(user);
                }
            }
        }

        public void Add(User user)
        {
            using (var context = new CarRentalContext())
            {
                var newUser = Convert.ToDataModel(user);
                context.User.Add(newUser);
                context.SaveChanges();
            }
        }

        public User Get(int id)
        {
            using (var context = new CarRentalContext())
            {
                var user = context.User.Single(u => u.Id == id);
                return Convert.FromDataModel(user);
            }
        }

        public User Remove(int id)
        {
            using (var context = new CarRentalContext())
            {
                var user = context.User.Single(u => u.Id == id);
                user.UserType = (int)Enums.UserTypes.Noone;
                context.SaveChanges();

                return Convert.FromDataModel(user);
            }
        }

        public void Update(User user)
        {
            using (var context = new CarRentalContext())
            {
                var updateUser = context.User.Single(u => u.Id == user.Id);
                updateUser = Convert.ToDataModel(user);
                context.SaveChanges();
            }
        }
    }
}
