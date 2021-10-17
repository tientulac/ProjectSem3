using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class ManagerDAL
    {
        private LinqDataContext db;
        public ManagerDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Manager_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Manager_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Manager_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- MANAGER COMMUNITY------------------------------------------------
        public ISingleResult<sp_ManagerCommunity_Load_ListResult> ManagerCommunity_Load()
        {
            ISingleResult<sp_ManagerCommunity_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ManagerCommunity_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- MANAGER EVENT------------------------------------------------
        public ISingleResult<sp_ManagerEvent_Load_ListResult> ManagerEvent_Load()
        {
            ISingleResult<sp_ManagerEvent_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ManagerEvent_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        //-------------------------------- MANAGER POST------------------------------------------------
        public ISingleResult<sp_ManagerPost_Load_ListResult> ManagerPost_Load()
        {
            ISingleResult<sp_ManagerPost_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ManagerPost_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Manager_InsertResult> Insert(RequestManager req)
        {
            ISingleResult<sp_Manager_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Manager_Insert(req.ManagerName,req.Address,req.Email,req.Phone,req.Gender,req.Birth,req.UserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Manager_UpdateResult> Update(RequestManager req)
        {
            ISingleResult<sp_Manager_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Manager_Update(req.ManagerName, req.Address, req.Email, req.Phone, req.Gender, req.Birth, req.UserId,req.ManagerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_ManagerEvent_DeleteResult> Delete(int ManagerId)
        {
            ISingleResult<sp_ManagerEvent_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_ManagerEvent_Delete(ManagerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}