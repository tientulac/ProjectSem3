using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class PostTypeDAL
    {
        private LinqDataContext db;
        public PostTypeDAL()
        {
            db = new LinqDataContext();
        }

        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_PostType_Load_ListResult> Load_List()
        {
            ISingleResult<sp_PostType_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_PostType_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_PostType_InsertResult> Insert(RequestPostType req)
        {
            ISingleResult<sp_PostType_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_PostType_Insert(req.PostTypeName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_PostType_UpdateResult> Update(RequestPostType req)
        {
            ISingleResult<sp_PostType_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_PostType_Update(req.PostTypeName, req.PostTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_SupportType_DeleteResult> Delete(int PostTypeId)
        {
            ISingleResult<sp_SupportType_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_SupportType_Delete(PostTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}