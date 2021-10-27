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
    [RoutePrefix("Local")]
    [AllowAnonymous]
    public class LocalController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        LocalDAL localDAL = new LocalDAL();
        LogController objUserEvent = new LogController();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseLocal res = new ResponseLocal();
            try
            {
                var lst = (from a in localDAL.Load_List()
                           select new RequestLocal
                           {
                               LocalId = a.LocalId,
                               LocalCode = a.LocalCode,
                               LocalName = a.LocalName
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
        public async Task<ResponseBase> Insert(RequestLocal req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = localDAL.Insert(req);
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
        public async Task<ResponseBase> Update(RequestLocal req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = localDAL.Update(req);
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
        public async Task<ResponseBase> Delete(int LocalId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = localDAL.Delete(LocalId);
                if (rs.FirstOrDefault().Deleted > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Xóa thành công !";
                    objUserEvent.Insert(
                           1,
                           3,
                           "Xóa bản ghi có ID" + LocalId,
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