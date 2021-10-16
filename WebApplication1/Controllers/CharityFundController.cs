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
    [RoutePrefix("CharityFund")]
    [AllowAnonymous]
    public class CharityFundController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        CharityFundDAL cfDAL = new CharityFundDAL();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseCharityFund res = new ResponseCharityFund();
            try
            {
                var lst = (from a in cfDAL.Load_List()
                           select new RequestCharityFundDTO
                           {
                               FundId = a.FundId,
                               FundName = a.FundName,
                               TotalAmount = a.TotalAmount.GetValueOrDefault(),
                               TypeId = a.TypeId.GetValueOrDefault(),
                               TypeName = a.TypeName
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
        public async Task<ResponseBase> Insert(RequestCharityFund req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cfDAL.Insert(req);
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
        public async Task<ResponseBase> Update(RequestCharityFund req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cfDAL.Update(req);
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
        public async Task<ResponseBase> Delete(int FundId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = cfDAL.Delete(FundId);
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