using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                    var User = MemberLogin.FirstOrDefault();
                    res.Info = new UserInfo();
                    UserInfo us = new UserInfo();
                    us.UserID = User.UserId;
                    us.FullName = User.FullName;
                    us.Email = User.Email;
                    us.UserCategory = User.UserCategory.GetValueOrDefault();
                    us.UserName = req.UserName;


                    res.Token = API.createToken(req.UserName);
                    res.Info = us;
                    res.Status = StatusID.Success;
                    res.Message = "Đăng nhập thành công !";
                    var json = new JavaScriptSerializer().Serialize(req);
                    objUserEvent.Insert(
                           0,
                           6,
                           "Đăg nhập thành công " + json,
                           us.UserName
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
    }
}