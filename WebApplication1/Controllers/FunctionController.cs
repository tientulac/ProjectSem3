using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;
using WebApplication1.Models.OutputModel;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Function")]
    [AllowAnonymous]
    public class FunctionController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        LogController objUserEvent = new LogController();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseFuntion res = new ResponseFuntion();
            try
            {
                var lst = (from a in db.htFunctions
                           select new RequestFunction
                           {
                               FunctionId = a.FuntionId,
                               FunctionCode = a.FunctionCode,
                               FunctionName = a.FunctionName
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

        //-------------------------------- GET ALL Functions by UserID--------------------------------------------
        [HttpGet]
        [Route("Get_Function_UserID")]
        public async Task<HttpResponseMessage> Get_Function_UserID(int UserId)
        {
            ResponseFuntion res = new ResponseFuntion();
            try
            {
                var lst = (from a in db.sp_htFunction_Load_User(UserId)
                           select new RequestFunction
                           {
                               FunctionId = a.FuntionId,
                               FunctionCode = a.FunctionCode,
                               FunctionName = a.FunctionName
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
        public async Task<ResponseBase> Insert(RequestFunction req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = db.sp_htFunctions_Insert(req.FunctionCode,req.FunctionName);
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Đã thêm mới quyền !";

                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                        1,
                        1,
                        "Thêm mới quyền" + json,
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
        public async Task<ResponseBase> Update(RequestFunction req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var check_insert = db.sp_htFunctions_Load_List().Where(M => M.FunctionName == req.FunctionName && req.FunctionId != req.FunctionId).Any();
                var check_insert2 = db.sp_htFunctions_Load_List().Where(M => M.FunctionCode == req.FunctionCode && M.FuntionId != req.FunctionId).Any();
                if (check_insert)
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Quyền đã bị trùng tên. Cập nhật thất bại !";
                }
                else if (check_insert2)
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Quyền đã bị trùng mã. Cập nhật thất bại !";
                }
                var rs = db.sp_htFunctions_Update(req.FunctionCode,req.FunctionName,req.FunctionId);
                if (rs.FirstOrDefault().Updated == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Quyền đã được cập nhật";

                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                        1,
                        2,
                        "Cập nhật quyền" + json,
                        User.Identity.Name
                   ); // tạo sự kiện người dùng
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể lưu quyền lúc này, vui lòng thử lại sau!";
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
        public async Task<ResponseBase> Delete_Function(int FunctionId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = db.sp_htFunctions_Delete(FunctionId);
                if (rs.FirstOrDefault().Deleted == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Quyền đã được xóa!";

                    objUserEvent.Insert(
                        1,
                        3,
                        "Xóa quyền có ID: " + FunctionId,
                        User.Identity.Name
                   ); // tạo sự kiện người dùng
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể xóa quyền lúc này, vui lòng thử lại sau!";
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