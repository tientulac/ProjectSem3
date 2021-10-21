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
    [RoutePrefix("Manager")]
    [AllowAnonymous]
    public class ManagerController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        ManagerDAL managerDAL = new ManagerDAL();
        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseManager res = new ResponseManager();
            try
            {
                var lst = (from a in managerDAL.Load_List()
                           select new RequestManager
                           {
                               ManagerId = a.ManagerId,
                               ManagerName = a.ManagerName,
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
        [Route("ManagerCommunity_Load")]
        public async Task<HttpResponseMessage> ManagerCommunity_Load()
        {
            ResponseManager res = new ResponseManager();
            try
            {
                var lst = (from a in managerDAL.ManagerCommunity_Load()
                           select new RequestManagerCommunityDTO
                           {
                               ManagerId = a.ManagerId,
                               ManagerName = a.ManagerName,
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
                               Url = a.Url
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
        [Route("ManagerEvent_Load")]
        public async Task<HttpResponseMessage> ManagerEvent_Load()
        {
            ResponseManager res = new ResponseManager();
            try
            {
                var lst = (from a in managerDAL.ManagerEvent_Load()
                           select new RequestManagerEventDTO
                           {
                               ManagerId = a.ManagerId,
                               ManagerName = a.ManagerName,
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
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt"
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
        [Route("ManagerPost_Load")]
        public async Task<HttpResponseMessage> ManagerPost_Load()
        {
            ResponseManager res = new ResponseManager();
            try
            {
                var lst = (from a in managerDAL.ManagerPost_Load()
                           select new RequestManagerPostDTO
                           {
                               ManagerId = a.ManagerId,
                               ManagerName = a.ManagerName,
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
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt"
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
        public async Task<ResponseBase> Insert(RequestManager req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = managerDAL.Insert(req);

                int err_com = 0;
                int success_com = 0;
                int err_event = 0;
                int success_event = 0;
                int err_post = 0;
                int success_post = 0;

                if (rs.FirstOrDefault().Identity > 0)
                {
                    if (req.List_com.Count() > 0)
                    {
                        foreach (var com in req.List_com)
                        {
                            var rs_com = db.sp_ManagerCommunity_Insert(req.ManagerId, req.CommunityId);
                            if (rs_com.Any())
                            {
                                success_com ++;
                            }
                            else
                            {
                                err_com ++;
                            }
                        }
                    }
                    if (req.List_event.Count() > 0)
                    {
                        var rs_event = db.sp_ManagerEvent_Insert(req.ManagerId, req.EventId);
                        if (rs_event.Any())
                        {
                            success_event ++;
                        }
                        else
                        {
                            err_event ++;
                        }
                    }
                    if (req.List_post.Count() > 0)
                    {
                        var rs_post = db.sp_ManagerPost_Insert(req.ManagerId, req.PostId);
                        if (rs_post.Any())
                        {
                            success_post ++;
                        }
                        else
                        {
                            err_post ++;
                        }
                    }
                    res.Status = StatusID.Success;
                    res.Message = String.Format(
                        "Thêm mới thành công {0} Cộng đồng, {1} Sự kiện, {2} Bài viết ! Thất bại {3} Cộng đồng, {4} Sự kiện, {5} Bài viết cho người quản lý",
                        success_com,success_event,success_post,err_com,err_event,err_post
                        );
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
        public async Task<ResponseBase> Update(RequestManager req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = managerDAL.Update(req);
                if (rs.FirstOrDefault().Updated > 0)
                {
                    var delete_com = db.sp_ManagerCommunity_Delete(req.ManagerId);
                    var delete_vent = db.sp_ManagerEvent_Delete(req.ManagerId);
                    var delete_post = db.sp_ManagerPost_Delete(req.ManagerId);
                    int err_com = 0;
                    int success_com = 0;
                    int err_event = 0;
                    int success_event = 0;
                    int err_post = 0;
                    int success_post = 0;

                    if (delete_com.Any() && delete_vent.Any() && delete_post.Any())
                    {
                        if (req.List_com.Count() > 0)
                        {
                            foreach (var com in req.List_com)
                            {
                                var rs_com = db.sp_ManagerCommunity_Insert(req.ManagerId, req.CommunityId);
                                if (rs_com.Any())
                                {
                                    success_com++;
                                }
                                else
                                {
                                    err_com++;
                                }
                            }
                        }
                        if (req.List_event.Count() > 0)
                        {
                            var rs_event = db.sp_ManagerEvent_Insert(req.ManagerId, req.EventId);
                            if (rs_event.Any())
                            {
                                success_event++;
                            }
                            else
                            {
                                err_event++;
                            }
                        }
                        if (req.List_post.Count() > 0)
                        {
                            var rs_post = db.sp_ManagerPost_Insert(req.ManagerId, req.PostId);
                            if (rs_post.Any())
                            {
                                success_post++;
                            }
                            else
                            {
                                err_post++;
                            }
                        }
                        res.Status = StatusID.Success;
                        res.Message = String.Format(
                            "Cập nhật thành công {0} Cộng đồng, {1} Sự kiện, {2} Bài viết ! Thất bại {3} Cộng đồng, {4} Sự kiện, {5} Bài viết cho người quản lý",
                            success_com, success_event, success_post, err_com, err_event, err_post
                            );
                    }
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
        public async Task<ResponseBase> Delete(int ManagerId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = managerDAL.Delete(ManagerId);
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