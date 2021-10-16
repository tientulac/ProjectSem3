using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class CommunityDonateDAL
    {
        private LinqDataContext db;
        public CommunityDonateDAL()
        {
            db = new LinqDataContext();
        }

        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_CommunityDonate_Load_ListResult> Load_List()
        {
            ISingleResult<sp_CommunityDonate_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_CommunityDonate_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_CommunityDonate_InsertResult> Insert(RequestCommunityDonate req)
        {
            ISingleResult<sp_CommunityDonate_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_CommunityDonate_Insert(req.CommunityName,req.Description,req.Url,req.Slot,req.TotalAmount,req.TypeId,req.LocalId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_CommunityDonate_UpdateResult> Update(RequestCommunityDonate req)
        {
            ISingleResult<sp_CommunityDonate_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_CommunityDonate_Update(req.CommunityName, req.Description, req.Url, req.Slot, req.TotalAmount, req.TypeId, req.LocalId,req.CommunityId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_CommunityDonate_DeleteResult> Delete(int CommunityId)
        {
            ISingleResult<sp_CommunityDonate_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_CommunityDonate_Delete(CommunityId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}