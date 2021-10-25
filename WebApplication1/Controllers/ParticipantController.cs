using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;
using WebApplication1.Models.OutputModel;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Participant")]
    [AllowAnonymous]
    public class ParticipantController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        ParticipantDAL participantDAL = new ParticipantDAL();
        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseParticipant res = new ResponseParticipant();
            try
            {
                var lst = (from a in participantDAL.Load_List()
                           select new RequestParticipant
                           {
                               ParticipantId = a.ParticipantId,
                               ParticipantName = a.ParticipantName,
                               DonateAmount = a.DonateAmount.GetValueOrDefault(),
                               Address = a.Address,
                               Email = a.Email,
                               Phone = a.Phone,
                               Gender = a.Gender.GetValueOrDefault(),
                               Birth = a.Birth.GetValueOrDefault(),
                               UserId = a.UserId.GetValueOrDefault(),
                               GenderName = a.Gender == true ? "Nam" : "Nữ"
                           }).ToList();
                res.Data = lst;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }

            var stringdata = JsonConvert.SerializeObject(res);

            var responseResult = new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };

            return await Task.FromResult(responseResult);
        }

        [HttpGet]
        [Route("ParticipantCommunity_Load")]
        public async Task<HttpResponseMessage> ParticipantCommunity_Load()
        {
            ResponseParticipant res = new ResponseParticipant();
            try
            {
                var lst = (from a in participantDAL.ParticipantCommunity_Load()
                           select new RequestParticipantCommunityDTO
                           {
                               ParticipantId = a.ParticipantId,
                               ParticipantName = a.ParticipantName,
                               DonateAmount = a.DonateAmount.GetValueOrDefault(),
                               Address = a.Address,
                               Email = a.Email,
                               Phone = a.Phone,
                               Gender = a.Gender.GetValueOrDefault(),
                               Birth = a.Birth.GetValueOrDefault(),
                               UserId = a.UserId.GetValueOrDefault(),
                               GenderName = a.Gender == true ? "Nam" : "Nữ",
                               CommunityId = a.CommunityId,
                               CommunityName = a.CommunityName,
                               Description = a.Description,
                               LocalId = a.LocalId.GetValueOrDefault(),
                               LocalName = a.LocalName,
                               Slot = a.Slot.GetValueOrDefault(),
                               TotalAmount = a.TotalAmount.GetValueOrDefault(),
                               SupportTypeId = a.SupportTypeId.GetValueOrDefault(),
                               SupportTypeName = a.SupportTypeName,
                               Url = a.Url,
                               Money = a.Money.GetValueOrDefault(),
                               MoneyTypeId = a.MoneyTypeId,
                               MoneyTypeName = a.MoneyTypeName,
                               Ratio = a.Ratio.GetValueOrDefault()
                           }).ToList();
                res.DataCom = lst;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }

            var stringdata = JsonConvert.SerializeObject(res);

            var responseResult = new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };

            return await Task.FromResult(responseResult);
        }

        [HttpGet]
        [Route("ParticipantEvent_Load")]
        public async Task<HttpResponseMessage> ParticipantEvent_Load()
        {
            ResponseParticipant res = new ResponseParticipant();
            try
            {
                var lst = (from a in participantDAL.ParticipantEvent_Load()
                           select new RequestParticipantEventDTO
                           {
                               ParticipantId = a.ParticipantId,
                               ParticipantName = a.ParticipantName,
                               Address = a.Address,
                               Email = a.Email,
                               Phone = a.Phone,
                               Gender = a.Gender.GetValueOrDefault(),
                               Birth = a.Birth.GetValueOrDefault(),
                               UserId = a.UserId.GetValueOrDefault(),
                               GenderName = a.Gender == true ? "Nam" : "Nữ",
                               EventId = a.EventId,
                               EventName = a.EventName,
                               FromDate = a.FromDate.GetValueOrDefault(),
                               ToDate = a.ToDate.GetValueOrDefault(),
                               Content = a.Content,
                               Slot = a.Slot.GetValueOrDefault(),
                               DesiredAmount = a.DesiredAmount.GetValueOrDefault(),
                               DonateAmount = a.DonateAmount.GetValueOrDefault(),
                               SupportTypeId = a.SupportTypeId.GetValueOrDefault(),
                               LocalId = a.LocalId.GetValueOrDefault(),
                               Status = a.Status.GetValueOrDefault(),
                               SupportTypeName = a.SupportTypeName,
                               LocalName = a.LocalName,
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt",
                               DonateByParticipant = a.DonateByParticipant.GetValueOrDefault(),
                               Money = a.Money.GetValueOrDefault(),
                               MoneyTypeId = a.MoneyTypeId,
                               MoneyTypeName = a.MoneyTypeName,
                               Ratio = a.Ratio.GetValueOrDefault()
                           }).ToList();
                res.DataEvent = lst;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }

            var stringdata = JsonConvert.SerializeObject(res);

            var responseResult = new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };

            return await Task.FromResult(responseResult);
        }

        [HttpGet]
        [Route("ParticipantPost_Load")]
        public async Task<HttpResponseMessage> ParticipantPost_Load()
        {
            ResponseParticipant res = new ResponseParticipant();
            try
            {
                var lst = (from a in participantDAL.ParticipantPost_Load()
                           select new RequestParticipantPostDTO
                           {
                               ParticipantId = a.ParticipantId,
                               ParticipantName = a.ParticipantName,
                               Address = a.Address,
                               Email = a.Email,
                               Phone = a.Phone,
                               Gender = a.Gender.GetValueOrDefault(),
                               Birth = a.Birth.GetValueOrDefault(),
                               UserId = a.UserId.GetValueOrDefault(),
                               GenderName = a.Gender == true ? "Nam" : "Nữ",
                               PostId = a.PostId,
                               PostName = a.PostName,
                               Slot = a.Slot.GetValueOrDefault(),
                               Content = a.Content,
                               Image = a.Image,
                               Status = a.Status.GetValueOrDefault(),
                               TotalAmount = a.TotalAmount.GetValueOrDefault(),
                               SupportTypeId = a.SupportTypeId.GetValueOrDefault(),
                               SupportTypeName = a.SupportTypeName,
                               PostTypeId = a.PostTypeId.GetValueOrDefault(),
                               PostTypeName = a.PostTypeName,
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt",
                               DonateAmount = a.DonateAmount.GetValueOrDefault(),
                               Money = a.Money.GetValueOrDefault(),
                               MoneyTypeId = a.MoneyTypeId,
                               MoneyTypeName = a.MoneyTypeName,
                               Ratio = a.Ratio.GetValueOrDefault()
                           }).ToList();
                res.DataPost = lst;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }

            var stringdata = JsonConvert.SerializeObject(res);

            var responseResult = new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };

            return await Task.FromResult(responseResult);
        }

        //-------------------------------- INSERT--------------------------------------------
        [HttpPost]
        [Route("Insert")]
        public async Task<ResponseBase> Insert(RequestParticipant req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = participantDAL.Insert(req);
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Thêm mới thành công !";
                }
                else
                {
                    res.Status = StatusID.Success;
                    res.Message = "Thêm mới thất bại !";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        //-------------------------------- UPDATE--------------------------------------------
        [HttpPost]
        [Route("Update")]
        public async Task<ResponseBase> Update(RequestParticipant req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = participantDAL.Update(req);
                if (rs.FirstOrDefault().Updated > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Cập nhật thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Cập nhật thất bại !";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        //-------------------------------- DELETE--------------------------------------------
        [HttpGet]
        [Route("Delete")]
        public async Task<ResponseBase> Delete(int ParticipantId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = participantDAL.Delete(ParticipantId);
                if (rs.FirstOrDefault().Deleted > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Xóa thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Xóa thất bại !";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }
    }
}