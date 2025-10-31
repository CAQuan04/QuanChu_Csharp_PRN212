using AirConditionerShop.DAL.Entites;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConditionerService

    {
        //                  BLL         DALL
        //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
        //                  !!!
        //SERVICE CHỨA CÁC HÀM CUNG CẤP CÁC CONTROLLER XÀI 
        //  NÓ CẦN REPO TRỢ GIÚP, CHỨ KO BAY THẲNG XUỐNG DBCONTEXT
        //SERVICE PHẢI KHAI BÁO BIẾN CỦA REPO, Y CHANG REPO KHAI BÁO BIẾN DBCONTEXT


        //HÀM 1: GetAllAirCons() chúng mình chỉ gọi REPO giúp

        //@Autowire: ko cần new Repo, mà để nơi khác new , và nơi đó đưa obj vào đây qua 3 cách: field = ; constructor =; setter =
        //NEW NƠI KHÁC TIÊM, CHÍCH, ĐƯA VÀO, INSERT (VERB), INJECTION (NOUN)
        //HIỆN TƯỢNG DEPENDENCY INJECTION
        //JAVA: NHÌN RÕ HƠN C# CÁI = VỤ DI (DEPENDENCY INJECTION)


        //                        DEPENDENCY INJECTION,DEPENDENCY INJECTION,DEPENDENCY INJECTION
        //C#: GIẤU KĨ HƠN QUA FILE PROGRAM.CS , SEREVICE BUIDER, NƠI CÁI NÓ NEW GIÚP MÌNH, ĐƯA VÀO CLASS NÀY CHO MÌNH
        //      NƠI NEW, ĐƯA VÀO CHO CLASS MÌNH XÀI: IoC Container
        //              Inversion of Control Container

        //NGINX: Nghe là gì
        //RAG: CHO AI HỌC DATA CỦA MÌNH


        private AirConditionerRepo _repo = new();//new luôn; vì DBContext đã đc new và kiểm soát bởi bên trong REPO rồi, tính đóng gói!!!!!


        //KHAI BÁO BIẾN REPO VÀ NEW REPO()
        //



        public List<AirConditioner>GetALlAirCons()
        {
            return _repo.GetAll();
        }

        //Hàm 2: CreateAirCon()
        public void CreateAirCon(AirConditioner obj)
        {
            _repo.Create(obj);
        }

        //Hàm 3: UpdateAirCon()
        public void UpdateAirCon(AirConditioner obj)
        {
            _repo.Update(obj);
        }


        //Hàm 4: DeleteAirCon()
        public void DeleteAirCon(AirConditioner obj)
        {
            _repo.Delete(obj);
        }

        //Hàm 5: SearchAirCon()

        //HÀM 6,7,8: GỌI MOMO, GỌI FIREBASE, GỌI GHN,......., TÌM VOUCHER....
        //TÍNH TOÁN CÁC IF ELSE CỦA BUSINESS RULE
    }
}


//DI -> SOLD