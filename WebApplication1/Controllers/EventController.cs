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
    [RoutePrefix("Event")]
    [AllowAnonymous]
    public class EventController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        EventDAL eventDAL = new EventDAL();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseEvent res = new ResponseEvent();
            try
            {
                var lst = (from a in eventDAL.Load_List()
                           select new RequestEventDTO
                           {
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
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt"
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

        //-------------------------------- INSERT--------------------------------------------
        [HttpPost]
        [Route("Insert")]
        public async Task<ResponseBase> Insert(RequestEvent req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = eventDAL.Insert(req);
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Thêm mới thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
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
        public async Task<ResponseBase> Update(RequestEvent req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = eventDAL.Update(req);
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
        public async Task<ResponseBase> Delete(int EventId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = eventDAL.Delete(EventId);
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