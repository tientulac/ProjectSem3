using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class DonorDAL
    {
        private LinqDataContext db;

        public DonorDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Donor_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Donor_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Donor_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Donor_InsertResult> Insert(RequestDonor req)
        {
            ISingleResult<sp_Donor_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Donor_Insert(req.DonorName,req.Address,req.Email,req.Phone,req.TotalAmount,req.Status,req.SupportTypeId,req.LocalId,req.Image,req.Title);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Donor_UpdateResult> Update(RequestDonor req)
        {
            ISingleResult<sp_Donor_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Donor_Update(req.DonorName, req.Address, req.Email, req.Phone, req.TotalAmount, req.Status, req.SupportTypeId, req.LocalId,req.Image,req.Title,req.DonorId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_Donor_DeleteResult> Delete(int DonorId)
        {
            ISingleResult<sp_Donor_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_Donor_Delete(DonorId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}