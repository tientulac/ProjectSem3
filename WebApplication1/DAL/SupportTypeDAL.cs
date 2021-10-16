using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class SupportTypeDAL
    {
        private LinqDataContext db;
        public SupportTypeDAL()
        {
            db = new LinqDataContext();
        }

        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_SupportType_Load_ListResult> Load_List()
        {
            ISingleResult<sp_SupportType_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_SupportType_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_SupportType_InsertResult> Insert(RequestSupportType req)
        {
            ISingleResult<sp_SupportType_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_SupportType_Insert(req.TypeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_SupportType_UpdateResult> Update(RequestSupportType req)
        {
            ISingleResult<sp_SupportType_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_SupportType_Update(req.TypeName, req.TypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_SupportType_DeleteResult> Delete(int TypeId)
        {
            ISingleResult<sp_SupportType_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_SupportType_Delete(TypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}