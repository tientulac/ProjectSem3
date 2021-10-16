using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class LocalDAL
    {
        private LinqDataContext db;
        public LocalDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Local_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Local_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Local_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Local_InsertResult> Insert(RequestLocal req)
        {
            ISingleResult<sp_Local_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Local_Insert(req.LocalCode,req.LocalName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Local_UpdateResult> Update(RequestLocal req)
        {
            ISingleResult<sp_Local_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Local_Update(req.LocalCode, req.LocalName,req.LocalId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_Local_DeleteResult> Delete(int LocalId)
        {
            ISingleResult<sp_Local_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_Local_Delete(LocalId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}