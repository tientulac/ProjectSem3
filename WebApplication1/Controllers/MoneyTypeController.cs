using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;
using WebApplication1.Models.OutputModel;

namespace WebApplication1.Controllers
{
    [RoutePrefix("MoneyType")]
    [AllowAnonymous]
    public class MoneyTypeController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        MoneyTypeDAL moneyDAL = new MoneyTypeDAL();
        LogController objUserEvent = new LogController();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseMoneyType res = new ResponseMoneyType();
            try
            {
                var lst = (from a in moneyDAL.Load_List()
                           select new RequestMoneyType
                           {
                               MoneyTypeId = a.MoneyTypeId,
                               MoneyTypeName = a.MoneyTypeName,
                               Ratio = a.Ratio.GetValueOrDefault()
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
        public async Task<ResponseBase> Insert(RequestMoneyType req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = moneyDAL.Insert(req);
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Thêm mới thành công !";
                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                           1,
                           1,
                           "Thêm mới bản ghi " + json,
                           User.Identity.Name
                           ); // tạo sự kiện người dùng
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
        public async Task<ResponseBase> Update(RequestMoneyType req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = moneyDAL.Update(req);
                if (rs.FirstOrDefault().Updated > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Cập nhật thành công !";
                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                           1,
                           2,
                           "Cập nhật bản ghi " + json,
                           User.Identity.Name
                           ); // tạo sự kiện người dùng
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
        public async Task<ResponseBase> Delete(int MoneyTypeId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = moneyDAL.Delete(MoneyTypeId);
                if (rs.FirstOrDefault().Deleted > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Xóa thành công !";
                    objUserEvent.Insert(
                           1,
                           3,
                           "Xóa bản ghi có ID" + MoneyTypeId,
                           User.Identity.Name
                           ); // tạo sự kiện người dùng
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