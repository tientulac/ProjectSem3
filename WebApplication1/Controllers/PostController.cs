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
    [RoutePrefix("Post")]
    [AllowAnonymous]
    public class PostController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        PostDAL postDAL = new PostDAL();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponsePost res = new ResponsePost();
            try
            {
                var lst = (from a in postDAL.Load_List()
                           select new RequestPostDTO
                           {
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
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt",
                               Title = a.Title
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
        public async Task<ResponseBase> Insert(RequestPost req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = postDAL.Insert(req);
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
        public async Task<ResponseBase> Update(RequestPost req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = postDAL.Update(req);
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

        //-------------------------------- UPDATE STATUS--------------------------------------------
        [HttpPost]
        [Route("UpdateStatus")]
        public async Task<ResponseBase> UpdateStatus(RequestPostDTO req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                int success_count = 0;
                int error_count = 0;
                int status;
                if (!req.checkLock)
                {
                    status = 3;
                }
                else
                {
                    status = 2;
                }
                if (req.list_post.Count() > 0)
                {
                    foreach (var item in req.list_post)
                    {
                        var rs = db.sp_UpdateStatus_Post(status, item.PostId);
                        if (rs.FirstOrDefault().Updated > 0)
                        {
                            res.Status = StatusID.Success;
                            success_count++;
                        }
                        else
                        {
                            res.Status = StatusID.InternalServer;
                            error_count++;
                        }
                    }
                    res.Status = StatusID.Success;
                    res.Message = String.Format("Cập nhật trạng thái {0} bản ghi, thất bại {1} bản ghi", success_count, error_count);
                }

                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Bạn chưa chọn bản ghi cần cập nhật !";
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
        public async Task<ResponseBase> Delete(int PostId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = postDAL.Delete(PostId);
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