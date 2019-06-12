using carriOS_Administrativo.Models.Entitties;
using carriOS_Administrativo.Models.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace carriOS_Administrativo.Models.RepositoryImpl
{
    public class BuisnessOwnerRepositoryImpl: BuisnessOwnerRepository
    {
        private carriOSDataBaseEntities db;
        private DbSet<BuisnessOwner> BuisnessOwner { get; set; }

        public BuisnessOwnerRepositoryImpl()
        {
            db = new carriOSDataBaseEntities();
            BuisnessOwner = db.Set<BuisnessOwner>();
        }

        public bool Save(BuisnessOwner t)
        {
            try
            {
                BuisnessOwner.Add(t);
                db.SaveChanges();
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(BuisnessOwner t)
        {
            try
            {
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(BuisnessOwner t)
        {
            try
            {
                db.Entry(t).State = EntityState.Deleted;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<BuisnessOwner> FindAll()
        {
            return db.BuisnessOwners.ToList();
        }

        public BuisnessOwner FindById(int? id)
        {
            return db.BuisnessOwners.Find(id);
        }
    }
}