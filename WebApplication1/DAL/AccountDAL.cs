using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        //-------------------------------- INSERT User--------------------------------------------
        public ISingleResult<sp_htUsers_InsertResult> User_Insert(RequestUser m)
        {
            ISingleResult<sp_htUsers_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Insert(m.UserName, m.Password, m.FullName, m.Admin, m.Active, m.Email, m.UserCategory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE User--------------------------------------------

        public ISingleResult<sp_htUsers_UpdateResult> User_Update(RequestUser m)
        {
            ISingleResult<sp_htUsers_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Update(
                    m.UserId,
                    m.FullName,
                    m.Admin,
                    m.Active,
                    m.Email,
                    m.UserCategory
                );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE User--------------------------------------------

        public ISingleResult<sp_htUsers_DeleteResult> User_Delete(int UserId)
        {
            ISingleResult<sp_htUsers_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Delete(UserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}