using carriOS_Administrativo.Models.Entitties;
using carriOS_Administrativo.Models.Repository;
using carriOS_Administrativo.Models.RepositoryImpl;
using carriOS_Administrativo.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace carriOS_Administrativo.Models.ServiceImpl
{
    public class BuisnessOwnerServiceImpl : BuisnessOwnerService
    {
        private BuisnessOwnerRepository buisnessOwnerRepository;

        public BuisnessOwnerServiceImpl()
        {
            buisnessOwnerRepository = new BuisnessOwnerRepositoryImpl();
        }

        bool CrudService<BuisnessOwner>.Delete(BuisnessOwner t)
        {
            return buisnessOwnerRepository.Delete(t);
        }

        List<BuisnessOwner> CrudService<BuisnessOwner>.FindAll()
        {
            return buisnessOwnerRepository.FindAll();
        }

        BuisnessOwner CrudService<BuisnessOwner>.FindById(int? id)
        {
            return buisnessOwnerRepository.FindById(id);
        }

        bool CrudService<BuisnessOwner>.Save(BuisnessOwner t)
        {
            return buisnessOwnerRepository.Save(t);
        }

        bool CrudService<BuisnessOwner>.Update(BuisnessOwner t)
        {
            return buisnessOwnerRepository.Update(t);
        }
    }
}