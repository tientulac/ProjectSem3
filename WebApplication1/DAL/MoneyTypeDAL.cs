using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class MoneyTypeDAL
    {
        private LinqDataContext db;

        public MoneyTypeDAL()
        {
            db = new LinqDataContext();
        }

        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_MoneyType_Load_ListResult> Load_List()
        {
            ISingleResult<sp_MoneyType_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_MoneyType_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_MoneyType_InsertResult> Insert(RequestMoneyType req)
        {
            ISingleResult<sp_MoneyType_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_MoneyType_Insert(req.MoneyTypeName,req.Ratio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_MoneyType_UpdateResult> Update(RequestMoneyType req)
        {
            ISingleResult<sp_MoneyType_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_MoneyType_Update(req.MoneyTypeName, req.Ratio, req.MoneyTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_MoneyType_DeleteResult> Delete(int MoneyTypeId)
        {
            ISingleResult<sp_MoneyType_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_MoneyType_Delete(MoneyTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}