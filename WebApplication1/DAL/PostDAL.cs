using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;


namespace WebApplication1.DAL
{
    public class PostDAL
    {
        private LinqDataContext db;
        public PostDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Post_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Post_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Post_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Post_InsertResult> Insert(RequestPost req)
        {
            ISingleResult<sp_Post_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Post_Insert(req.PostName,req.Slot,req.Content,req.Image,req.Status,req.TotalAmount,req.TypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Post_UpdateResult> Update(RequestPost req)
        {
            ISingleResult<sp_Post_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Post_Update(req.PostName, req.Slot, req.Content, req.Image, req.Status, req.TotalAmount, req.TypeId,req.PostId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_Post_DeleteResult> Delete(int PostId)
        {
            ISingleResult<sp_Post_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_Post_Delete(PostId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}