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
    [RoutePrefix("UserEvent")]
    [AllowAnonymous]
    public class LogController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();

        public ResponseBase Insert(int TypeEvent, int Perform, string Content, string UserName)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = db.sp_UserEvent_Insert(
                    TypeEvent,
                    Perform,
                    Content,
                    DateTime.Now,
                    GetLocalIPAddress(),
                    UserName
                   );
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return res;
        }

        public static string GetLocalIPAddress()
        {
            //var host = Dns.GetHostEntry(Dns.GetHostName());
            //foreach (var ip in host.AddressList)
            //{
            //    if (ip.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        return ip.ToString();
            //    }
            //}
            string ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ip))
            {
                ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip;

            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        [HttpGet]
        [Route("Load_List")]
        public HttpResponseMessage Load_List()
        {
            ResponseUserEvent res = new ResponseUserEvent();
            try
            {
                var list = (from a in db.sp_UserEvent_Load_List()
                            select new RequestUserEvent
                            {
                                UserEventId = a.UserEventId,
                                TypeEvent = a.TypeEvent.GetValueOrDefault(),
                                Perform = a.Perform.GetValueOrDefault(),
                                Content = a.Content,
                                Moment = a.Moment.GetValueOrDefault(),
                                IPAddress = a.IPAddress,
                                UserName = a.UserName,
                                TypeEventName = a.TypeEvent == 0 ? "ĐĂNG NHẬP" : a.TypeEvent == 1 ? "QUẢN LÝ DANH MỤC" : a.Perform == 2 ? "QUẢN LÝ CHỨC NĂNG" : a.Perform == 3 ? "QUẢN LÝ NGƯỜI DÙNG" : "QUẢN LÝ DONATE" ,
                                PerformName = (a.Perform == 1 ? "Thêm" : a.Perform == 2 ? "Sửa" : a.Perform == 3 ? "Xóa" : a.Perform == 4 ? "Duyệt" : a.Perform == 5 ? "Duyệt": "Đăng nhập"),
                            }).ToList();
                res.Data = list;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = StatusID.InternalServer;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }
    }
}