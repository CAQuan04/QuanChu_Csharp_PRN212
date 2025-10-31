using AirConditionerShop.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConditionerRepo
    {
        //GUI/CONTROLLER -- SERVICE -- REPO -- DBCONTEXT -- TABLE
        //                          !!!
        //Chứ hàm CRUD table AirCon, chắc chắn phải xài DBCONTEXT
        //Xài thì phải khai báo biến và new!!!!!
        private AirConditionerShopDbContext _ctx;
        //QUAN TRỌNG NHỚ ko new, CHỪNG NÀO XÀI MỚI NEW
        //MỖI HÀM NEW LẠI NÓ 1 NHẤT QUÁN VIỆC  QUẢN LÍ 
        //DỮ LIỆU CỦA CÁ TABLE

        //HÀM 1: SELECT * FROM AIRCON -> SHOW LÊN CÁI GRID
        public List<AirConditioner> GetAll()
        {
            //_ctx = new AirConditionerShopDbContext();
            _ctx = new();//new ngắn gọn
            //return _ctx.AirConditioners.ToList();

            return _ctx.AirConditioners.Include("Supplier").ToList();
                                    //(.) Remove, Update, Delete
                                    //Chấm để thêm xóa sửa


            //      vì cái túi gốc _bag trong DBContext nó là
            //  DBSet<AirCon> rất giống List<AirCon> nên là ta cần convert về List<> để dùng 
            //  .ToList() chính là convert về List
        }



        //HÀM 2: INSERT INTO AIRCON VALUES (....) -> CREATE
        public void Create(AirConditioner obj)
        {
            _ctx = new(); //luôn new lại DBContext để đảm bảo tính đồng bộ trong ram và table
            _ctx.AirConditioners.Add(obj);
            _ctx.SaveChanges(); //LỆNH NÀY MỚI XUỐNG TABLE THẬT SỰ, CHỈ CÓ SỰ THAY ĐỔI TRONG DB MỚI SAVECHANGES
        }


        //HÀM 3: UPDATE AIRCON SET CỘT-X - VALUE MỚI WHERE KEY -?
        //              -> UPDATE
        public void Update(AirConditioner obj)
        {
            _ctx = new(); //luôn new lại DBContext để đảm bảo tính đồng bộ trong ram và table
            _ctx.AirConditioners.Update(obj);
            _ctx.SaveChanges(); //LỆNH NÀY MỚI XUỐNG TABLE THẬT SỰ, CHỈ CÓ SỰ THAY ĐỔI TRONG DB MỚI SAVECHANGES 
        }


        //HÀM 4: DELETE FROM AIRCON WHERE KEY - ???? -> DELETE
        //Các hàm trong Repo đặt tên rất ngắn gọn,vì nó rất gần table, mà table thì có 4 lệnh cơ bản:
        //Insert into AirCon values(...)
        //Update AirCon set cột-x = value mới, cột-y = value-mới where cột key = key của dòng muốn sửa
        //Delete from AirCon where cột key = key của dòng muốn xóa
        //select * from --> GET ALL
        //select * from AirCon where key = ..... cột khác =.....Keyword 
        //                           -> tìm kiếm 1 dòng hay nhiều dòng
        //TÊN HÀM TRONG REPO ĐẶT NGẮN GỌN GIỐNG NHƯ LỆNH SQL VÌ NÓ THAO TÁC TRÊN TABLE
        //TÊN HÀM TRONG SERVICE THÌ ĐẶT CHI TIẾT HƠN, RÕ RÀNG HƠN DO NÓ GẰN GŨI / GẦN GUI, HƯỚNG VỀ NGƯỜI DÙNG

        //DELETE KHÔNG NHỚ: KKO WHERE THÌ TOANG TOÀN BỘ TABLE!!!!
        //TABLE TRONG ORM / OBJECT RELATIONAL MAPPING, CHƠI CSDL CÓ KEY RỒI
        //HOẶC BẠN ĐƯA KEY ĐỂ XÓA
        // HOẠCW BẠN ĐƯA 1 OBJECT ĐỂ XÓA, TRONG OBJECT CÓ KEY RỒI
        public void Delete(int key)
        {
            //VỀ nhà làm
        }


        //Nên dùng obj
        public void Delete(AirConditioner obj)
        {
            _ctx = new(); //luôn new lại DBContext để đảm bảo tính đồng bộ trong ram và table
            _ctx.AirConditioners.Remove(obj);// XÓA TRONG RAM
            _ctx.SaveChanges(); //LỆNH NÀY MỚI XUỐNG TABLE THẬT SỰ, CHỈ CÓ SỰ THAY ĐỔI TRONG DB MỚI SAVECHANGES
        }


        //HÀM 5: SELECT * FROM AIRCON WHERE CỘT - ?
        //                                  CỘT LIKE '%KEYWORD%'  -> SEARCH
        //                                  


    }
}
