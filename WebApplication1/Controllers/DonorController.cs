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
    [RoutePrefix("Donor")]
    [AllowAnonymous]
    public class DonorController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        DonorDAL donorDAL = new DonorDAL();

        //-------------------------------- GET ALL--------------------------------------------
        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseDonor res = new ResponseDonor();
            try
            {
                var lst = (from a in donorDAL.Load_List()
                           select new RequestDonorDTO
                           {
                               DonorId = a.DonorId,
                               DonorName = a.DonorName,
                               Address = a.Address,
                               Email = a.Email,
                               Phone = a.Phone,
                               TotalAmount = a.ToTalAmount.GetValueOrDefault(),
                               Status = a.Status.GetValueOrDefault(),
                               SupportTypeId = a.SupportTypeId.GetValueOrDefault(),
                               LocalId = a.LocalId.GetValueOrDefault(),
                               SupportTypeName = a.SupportTypeName,
                               LocalName = a.LocalName,
                               StatusName = a.Status == 1 ? "Chờ duyệt" : a.Status == 2 ? "Đã duyệt" : "Từ chối duyệt" 
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
        public async Task<ResponseBase> Insert(RequestDonor req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = donorDAL.Insert(req);
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
        public async Task<ResponseBase> Update(RequestDonor req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = donorDAL.Update(req);
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
        public async Task<ResponseBase> Delete(int DonorId)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = donorDAL.Delete(DonorId);
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