using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class ParticipantDAL
    {
        private LinqDataContext db;
        public ParticipantDAL()
        {
            db = new LinqDataContext();
        }
        //-------------------------------- LOAD LIST------------------------------------------------
        public ISingleResult<sp_Participant_Load_ListResult> Load_List()
        {
            ISingleResult<sp_Participant_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_Participant_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- PARTICIPANT COMMUNITY------------------------------------------------
        public ISingleResult<sp_ParticipantCommunity_Load_ListResult> ParticipantCommunity_Load()
        {
            ISingleResult<sp_ParticipantCommunity_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ParticipantCommunity_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- PARTICIPANT EVENT------------------------------------------------
        public ISingleResult<sp_ParticipantEvent_Load_ListResult> ParticipantEvent_Load()
        {
            ISingleResult<sp_ParticipantEvent_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ParticipantEvent_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        //-------------------------------- PARTICIPANT POST------------------------------------------------
        public ISingleResult<sp_ParticipantPost_Load_ListResult> ParticipantPost_Load()
        {
            ISingleResult<sp_ParticipantPost_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_ParticipantPost_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- INSERT------------------------------------------------
        public ISingleResult<sp_Participant_InsertResult> Insert(RequestParticipant req)
        {
            ISingleResult<sp_Participant_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_Participant_Insert(req.ParticipantName,req.Address,req.Email,req.Phone,req.Gender,req.Birth,req.UserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE------------------------------------------------
        public ISingleResult<sp_Participant_UpdateResult> Update(RequestParticipant req)
        {
            ISingleResult<sp_Participant_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_Participant_Update(req.ParticipantName, req.Address, req.Email, req.Phone, req.Gender, req.Birth, req.UserId,req.ParticipantId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE------------------------------------------------
        public ISingleResult<sp_Participant_DeleteResult> Delete(int ParticipantId)
        {
            ISingleResult<sp_Participant_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_Participant_Delete(ParticipantId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}