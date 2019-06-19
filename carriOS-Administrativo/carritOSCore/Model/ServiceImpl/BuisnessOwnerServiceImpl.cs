using carritOSCore.Model.Entities;
using carritOSCore.Model.Repository;
using carritOSCore.Model.RepositoryImpl;
using carritOSCore.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carritOSCore.Model.ServiceImpl
{
    public class BuisnessOwnerServiceImpl : IBuisnessOwnerService
    {
        private IBuisnessOwnerRepository buisnessOwnerRepository;

        public BuisnessOwnerServiceImpl(ApplicationDbContext context)
        {
            buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl(context);
        }

        public bool Delete(BuisnessOwner t)
        {
            throw new NotImplementedException();
        }

        public List<BuisnessOwner> FindAll()
        {
            return buisnessOwnerRepository.FindAll();
        }

        public BuisnessOwner FindById(int? id)
        {
            return buisnessOwnerRepository.FindById(id);
        }

        public bool Save(BuisnessOwner t)
        {
            throw new NotImplementedException();
        }

        public bool Update(BuisnessOwner t)
        {
            throw new NotImplementedException();
        }
    }
}
