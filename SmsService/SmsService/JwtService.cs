using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SmsService.Data;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SmsService
{
    public class JwtService
    {
        private IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateAccessToken(User user)
        {
            //        string signingKey = _configuration.GetValue<string>("Jwt:Key");
            //        string issuer = _configuration.GetValue<string>("Jwt:Issuer");
            //        int hours = _configuration.GetValue<int>("Jwt:HoursValid");
            //        System.DateTime expireDateTime = System.DateTime.UtcNow.AddHours(hours);

            //        byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);
            //        SymmetricSecurityKey secKey = new SymmetricSecurityKey(signingKeyBytes);
            //        SigningCredentials creds = new SigningCredentials(secKey, SecurityAlgorithms.HmacSha256);

            //        var authClaims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, user.Name)
            //};

            //        JwtSecurityToken token = new JwtSecurityToken(
            //            issuer: issuer,
            //            audience: issuer,
            //            claims: authClaims,
            //            expires: System.DateTime.UtcNow.AddHours(hours),
            //            signingCredentials: creds
            //        );
            //        JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            //        string writtenToken = handler.WriteToken(token);

            //        return writtenToken;
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"] , signingCredentials: signingCredentials,
                expires:DateTime.Now.AddHours(1));

            //SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[] {
            //          new Claim(ClaimTypes.Name,user.Name),
            //          new Claim(ClaimTypes.Email, user.Email)
            //    }),
            //    SigningCredentials = signingCredentials
            //};

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            //jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            return jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
        }
    }
}
