using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.Models.InputModel;

namespace WebApplication1.DAL
{
    public class AccountDAL
    {
        private LinqDataContext db;
        public AccountDAL()
        {
            db = new LinqDataContext();
        }
        public ISingleResult<sp_htUsers_LoginResult> User_Login(RequestLogin req)
        {
            ISingleResult<sp_htUsers_LoginResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Login(req.UserName, req.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}