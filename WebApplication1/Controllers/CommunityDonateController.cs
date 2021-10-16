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
    [RoutePrefix("CommunityDonate")]
    [AllowAnonymous]
    public class CommunityDonateController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        CommunityDonateDAL cdDAL = new CommunityDonateDAL();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseCommunityDonate res = new ResponseCommunityDonate();
            try
            {
                var lst = (from a in cdDAL.Load_List()
                           select new RequestCommunityDonateDTO
                           {
                               CommunityId = a.CommunityId,
                               CommunityName = a.CommunityName,
                               Description = a.Description,
                               LocalId = a.LocalId.GetValueOrDefault(),
                               LocalName = a.LocalName,
                               Slot = a.Slot.GetValueOrDefault(),
                               TotalAmount = a.TotalAmount.GetValueOrDefault(),
                               TypeId = a.TypeId.GetValueOrDefault(),
                               TypeName = a.TypeName,
                               Url = a.Url
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
        public async Task<ResponseBase> Insert(RequestCommunityDonate req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cdDAL.Insert(req);
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
        public async Task<ResponseBase> Update(RequestCommunityDonate req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cdDAL.Update(req);
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
        public async Task<ResponseBase> Delete(int CommunityId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cdDAL.Delete(CommunityId);
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