﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;

namespace WebApplication1.Models
{
    public class constant
    {
        public static string USER_SESSION = "USER_SESSION";
    }

    public class API
    {
        public static string createToken(string Username)
        {
            //Set issued at date
            DateTime issuedAt = DateTime.UtcNow;
            //đặt thời gian hết hạn token
            DateTime expires = DateTime.UtcNow.AddDays(10);

            //http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
            var tokenHandler = new JwtSecurityTokenHandler();

            //create a identity and add claims to the user which we want to log in

            var userIdentity = new ClaimsIdentity("Identity");
            userIdentity.Label = "Identity";
            userIdentity.AddClaim(new Claim(ClaimTypes.Name, Username));
            userIdentity.AddClaim(new Claim("Username", Username));
            //userIdentity.AddClaim(new Claim("Category", Category));
            //userIdentity.HasClaim(ClaimTypes.Role, Category);
            var claims = new List<Claim>();

            var identity = new ClaimsPrincipal(userIdentity);
            Thread.CurrentPrincipal = identity;
            if (HttpContext.Current != null)
            {
                HttpContext.Current.User = identity;
            }
            //string sec = EncryptCode;
            string sec = "088881139703564148785";
            //string sec = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1" + Category;
            var now = DateTime.UtcNow;
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(sec));
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);

            //create the jwt
            var token =
                (JwtSecurityToken)
                    tokenHandler.CreateJwtSecurityToken(issuer: "http://unisoft.edu.vn/", audience: "http://unisoft.edu.vn/",
                        subject: userIdentity, notBefore: issuedAt, expires: expires, signingCredentials: signingCredentials);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}