using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class CharityFundDAL
    {
        private LinqDataContext db;
        public CharityFundDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_CharityFund_Load_ListResult> Load_List()
        {
            ISingleResult<sp_CharityFund_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_CharityFund_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_CharityFund_InsertResult> Insert(RequestCharityFund req)
        {
            ISingleResult<sp_CharityFund_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_CharityFund_Insert(req.FundName,req.TotalAmount,req.SupportTypeId,req.Image);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_CharityFund_UPDATEResult> Update(RequestCharityFund req)
        {
            ISingleResult<sp_CharityFund_UPDATEResult> sp_result;
            try
            {
                sp_result = db.sp_CharityFund_UPDATE(req.FundName, req.TotalAmount, req.SupportTypeId, req.Image,req.FundId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_CharityFund_DeleteResult> Delete(int FundId)
        {
            ISingleResult<sp_CharityFund_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_CharityFund_Delete(FundId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}