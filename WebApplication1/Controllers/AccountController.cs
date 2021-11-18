using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;
using WebApplication1.Models.OutputModel;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Account")]
    public class AccountController : ApiController
    {
        private LinqDataContext db;
        public AccountController() // Khởi tạo kết nối SQL
        {
            db = new LinqDataContext();
        }
        AccountDAL objAccount = new AccountDAL();
        LogController objUserEvent = new LogController();

        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] frData = Encoding.UTF8.GetBytes(str);
            byte[] tgData = md5.ComputeHash(frData);
            string hashString = "";
            for (int i = 0; i < tgData.Length; i++)
            {
                hashString += tgData[i].ToString("x2");
            }
            return hashString;
        }

        /**
        * LOGIN ACCOUNT
        * Username
        * Password
        */
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public ResponseLogin Login([FromBody] RequestLogin req)
        {
            ResponseLogin res = new ResponseLogin();
            bool EnableRoles = Convert.ToBoolean(WebConfigurationManager.AppSettings["EnableRoles"]);

            try
            {
                req.Password = GetMD5(req.Password);
                var MemberLogin = objAccount.User_Login(req).ToList();
                if (MemberLogin.Count() != 1)
                {
                    res.Status = StatusID.AccessDenied;
                    res.Message = "Thông tin đăng nhập không chính xác";
                }
                else
                {
                    int participantId;
                    int UserCategory = (int)db.htUsers.Where(M => M.UserName == req.UserName).FirstOrDefault().UserCategory;
                    if (UserCategory == 1 || UserCategory == null)
                    {
                        participantId = 0;
                    }
                    else
                    {
                        int UserID_get = db.htUsers.Where(M => M.UserName == req.UserName).FirstOrDefault().UserId;
                        participantId = db.Participants.Where(M => M.UserId == UserID_get).FirstOrDefault().ParticipantId;
                    }                    
                    var User = MemberLogin.FirstOrDefault();
                    res.Info = new UserInfo();
                    UserInfo us = new UserInfo();
                    us.UserID = User.UserId;
                    us.FullName = User.FullName;
                    us.Email = User.Email;
                    us.UserName = req.UserName;
                    us.UserCategory = req.UserCategory;
                    us.ParticipantId = participantId;
                    // Lấy ra quyền của người dùng
                    var lst_functions = (from a in db.sp_htFunction_Load_User(us.UserID)
                                         select new RequestFunction
                                         {
                                             FunctionId = a.FuntionId,
                                             FunctionCode = a.FunctionCode,
                                             FunctionName = a.FunctionName
                                         }).ToList();
                    us.Functions = lst_functions;

                    res.Token = API.createToken(req.UserName);
                    res.Info = us;
                    res.Status = StatusID.Success;
                    res.Message = "Đăng nhập thành công !";

                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                        1,
                        0,
                        "Sự kiện đăng nhập" + json,
                        req.UserName
                   ); // tạo sự kiện người dùng
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return res;
        }


        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> GetUserList()
        {
            ResponseUser res = new ResponseUser();
            try
            {
                var lst = (from a in db.htUsers
                           orderby a.UserId descending
                           select new RequestUser
                           {
                               UserId = a.UserId,
                               UserName = a.UserName,
                               Password = a.PassWord,
                               FullName = a.FullName,
                               Email = a.Email,
                               Admin = a.Admin.GetValueOrDefault(),
                               Active = a.Active.GetValueOrDefault(),
                               StatusName = a.Active == true ? "Còn hiệu lực" : "Vô hiệu hóa",
                               UserCategory = a.UserCategory.GetValueOrDefault(),
                               UserCategoryName = a.UserCategory == 1 ? "Quản trị viên".ToUpper() : a.UserCategory == 2 ? "Tài khoản người dùng".ToUpper() : "Tài khoản tổ chức".ToUpper()
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
        public async Task<ResponseBase> Insert(RequestUser m)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                m.Password = GetMD5(m.Password);
                m.Active = m.Active == null ? false : true;
                m.Admin = m.Admin == null ? false : true;
                var Check = db.htUsers.Where(M => M.UserName == m.UserName);
                if (Check.Count() > 0)
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Tài khoản người dùng có tên " + m.UserName + " đã được tạo trước đó, vui lòng kiểm tra lại!";
                }
                else
                {
                    var rs = objAccount.User_Insert(m).ToList();
                    if (rs.FirstOrDefault().Identity > 0)
                    {
                        res.Status = StatusID.Success;
                        res.Message = "Thêm mới thành công !";
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Thêm thất bại";
                    }
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        //-------------------------------- UPDATE --------------------------------------------
        [HttpPost]
        [Route("Update")]
        public async Task<ResponseBase> Update(RequestUser m)
        {
            ResponseUser res = new ResponseUser();
            try
            {
                var rs = objAccount.User_Update(m);
                if (rs.FirstOrDefault().Updated == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Cập nhật thành công";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể lưu tài khoản người dùng lúc này, vui lòng thử lại sau!";
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
        public async Task<ResponseBase> Delete(int UserId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objAccount.User_Delete(UserId);
                if (rs.FirstOrDefault().Deleted == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Tài khoản người dùng đã được xóa!";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể xóa tài khoản người dùng lúc này, vui lòng thử lại sau!";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        //-------------------------------- Insert User Function---------------------------
        [HttpPost]
        [Route("Insert_User_Function")]
        public async Task<ResponseBase> Insert_User_Function(RequestUserFunction m)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                if (m.list_user_function.Count > 0)
                {
                    var sp_delete = db.sp_htUserFunction_Delete(m.UserId);
                    if (sp_delete.FirstOrDefault().Deleted >= 0)
                    {
                        for (var i = 0; i < m.list_user_function.Count; i++)
                        {
                            var sp_result = db.sp_htUserFunction_Insert(m.UserId, m.list_user_function[i]);
                            if (sp_result.FirstOrDefault().Identity == 1)
                            {
                                res.Status = StatusID.Success;
                                res.Message = "Tài khoản người dùng đã được cập nhật quyền";
                            }
                            else
                            {
                                res.Status = StatusID.InternalServer;
                                res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                            }
                        }
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                    }
                }
                else
                {
                    var sp_delete = db.sp_htUserFunction_Delete(m.UserId);
                    if (sp_delete.FirstOrDefault().Deleted > 0)
                    {
                        res.Status = StatusID.Success;
                        res.Message = "Tài khoản người dùng đã được cập nhật quyền";
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Danh sách quyền của người dùng để trống";
                    }
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