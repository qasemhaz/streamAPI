using Microsoft.IdentityModel.Tokens;
using Stream.Core.Data;
using Stream.Core.Repository;
using Stream.Core.Service;
using Stream.Infra.Repository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Text;

namespace Stream.Infra.Service
{
    public class LoginService : ILoginService
    {
        private readonly IStreamLogin streamLogin;
        public LoginService(IStreamLogin streamLogin)
        {
            this.streamLogin = streamLogin;
        }

        public string Auth(Streamlogin loginof)
        {

            var result = streamLogin.Auth(loginof);
            if (result == null)
            {
                return null;
            }
            else
            {

                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>{
                    new Claim("username", result.Username),

                    new Claim("userinfo", result.Userid.ToString()),
                 new Claim("role", result.Roleid.ToString())
};
                var tokeOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddSeconds(10),
                signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                return tokenString;

            }


        }


        public void Create(Streamlogin stream)
        {
            streamLogin.Create(stream);
        }

        public void Delete(int id)
        {
            streamLogin.Delete(id);
        }

        public List<Streamlogin> GetAll()
        {
            return streamLogin.GetAll();
        }

        public Streamlogin GetById(int id)
        {
            return streamLogin.GetById(id);
        }

        public void googl(string name, string email, string pass)
        {
            streamLogin.googl(name, email,pass);
        }

        public void Update(Streamlogin stream)
        {
            streamLogin.Update(stream);
        }
    }
}
