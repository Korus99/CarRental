using System.Collections.Generic;
using System.Linq;
using CarRentalApp.MobileAppService.Common;
using CarRentalApp.MobileAppService.DataModels;
using CarRentalApp.MobileAppService.Models;
using CarRentalApp.MobileAppService.Repository.Interface;

namespace CarRentalApp.MobileAppService.Business
{
    public class MaintenanceBusiness : IMaintenanceBusiness
    {
        public MaintenanceBusiness()
        {

        }

        public IEnumerable<Maintenance> GetAll()
        {
            using (var context = new CarRentalContext())
            {
                var maints = context.Maintenance.ToList();
                foreach (var maint in maints)
                {
                    yield return Convert.FromDataModel(maint);
                }
            }
        }

        public void Add(Maintenance maint)
        {
            using (var context = new CarRentalContext())
            {
                var newMaint = Convert.ToDataModel(maint);
                context.Maintenance.Add(newMaint);
                context.SaveChanges();
            }
        }

        public Maintenance Get(int id)
        {
            using (var context = new CarRentalContext())
            {
                var maint = context.Maintenance.Single(m => m.Id == id);
                return Convert.FromDataModel(maint);
            }
        }

        public Maintenance Remove(int id)
        {
            using (var context = new CarRentalContext())
            {
                var maint = context.Maintenance.Single(m => m.Id == id);
                maint.Completed = true;
                context.SaveChanges();

                return Convert.FromDataModel(maint);
            }
        }

        public void Update(Maintenance maint)
        {
            using (var context = new CarRentalContext())
            {
                var updateMaint = context.Maintenance.Single(m => m.Id == maint.Id);
                updateMaint = Convert.ToDataModel(maint);
                context.SaveChanges();
            }
        }
    }
}
