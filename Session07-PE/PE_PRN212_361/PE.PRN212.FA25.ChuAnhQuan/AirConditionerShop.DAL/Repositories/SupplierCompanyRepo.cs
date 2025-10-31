using AirConditionerShop.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    //                  BLL         DALL
    //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
    //                  !!!
    public class SupplierCompanyRepo
    {
        public AirConditionerShopDbContext _ctx;//chừng nòa xìa thì mới đc new


        //CRUD THÊM XÓA SỬA TÌM KIẾM NAHF CUNG CẤP!!!
        //THI PE KO CẦN THÊM XÓA SỬAM VÌ KO ĐỦ TGIAN
        
        //chỉ làm hàm getAll() vì cần nó cho troe dầu de bán thịt heo ở màn hình detail
        public List<SupplierCompany> GetAll()
        {
            _ctx = new();
            return _ctx.SupplierCompanies.ToList();
            //mày chứa 3 cái túi, ứng với 3 table
            //chấm là lấy hết data

        }
    }
}
