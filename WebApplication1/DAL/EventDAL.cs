using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class EventDAL
    {
        private LinqDataContext db;
        public EventDAL()
        {
            db = new LinqDataContext();
        }

        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Event_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Event_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Event_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Event_InsertResult> Insert(RequestEvent req)
        {
            ISingleResult<sp_Event_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Event_Insert(req.EventName,req.FromDate,req.ToDate,req.Content,req.Slot,req.DesiredAmount,req.DonateAmount,req.SupportTypeId, req.LocalId,req.Status,req.Image,req.Title);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Event_UpdateResult> Update(RequestEvent req)
        {
            ISingleResult<sp_Event_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Event_Update(req.EventName, req.FromDate, req.ToDate, req.Content, req.Slot, req.DesiredAmount, req.DonateAmount, req.SupportTypeId, req.LocalId,req.Status,req.EventId,req.Image,req.Title);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_Event_DeleteResult> Delete(int EventId)
        {
            ISingleResult<sp_Event_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_Event_Delete(EventId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}