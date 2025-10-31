using AirConditionerShop.DAL.Entites;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class SupplierCompanyService
    {
        //DI, kì 7 không ghi new mà dùng DI
        private SupplierCompanyRepo _repo = new();

        public List<SupplierCompany> GetAllSupplie()
        {
            return _repo.GetAll();
        }


    }
}
