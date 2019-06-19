using carritOSCore.Model.Entities;
using carritOSCore.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carritOSCore.Model.RepositoryImpl
{
    public class BuisnessOwnerRepositoryImpl : IBuisnessOwnerRepository
    {
        private readonly ApplicationDbContext context;

        public BuisnessOwnerRepositoryImpl(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(BuisnessOwner t)
        {
            try
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<BuisnessOwner> FindAll()
        {
            return context.buisnessOwners.ToList();
        }

        public BuisnessOwner FindById(int? id)
        {
            return context.buisnessOwners
              .Find(id);
        }

        public bool Save(BuisnessOwner t)
        {
            try
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(BuisnessOwner t)
        {
            try
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
