using EnergyAPI.Configurations;
using EnergyAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EnergyAPI.Controllers {

    [Route("api")]
    [ApiController]
    public class AuthController : Controller {

        private readonly JwtBearerTokenSettings jwtTokenSettings;
        private readonly UserManager<IdentityUser> userManager;

        public AuthController(IOptions<JwtBearerTokenSettings> jwtTokenSettings, UserManager<IdentityUser> userManager) {
            this.jwtTokenSettings = jwtTokenSettings.Value;
            this.userManager = userManager;
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Register([FromBody]Credentials credentials) {
            
            if(credentials == null) {
                return new BadRequestObjectResult(new { message = "Registration failed" });
            }
            
            
            var identityUser = new IdentityUser() { UserName = credentials.UserName };
            var result = await userManager.CreateAsync(identityUser, credentials.Password);
            if(!result.Succeeded) {
                var dictionary = new ModelStateDictionary();
                foreach(IdentityError error in result.Errors) {
                    dictionary.AddModelError(error.Code, error.Description);
                }

                return new BadRequestObjectResult(new { message = "Registration Failed", errors = dictionary });
            }

            return Ok(new { message = "Registration successfully" });
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]Credentials credentials) {

            IdentityUser identityUser;

            if(credentials == null || (identityUser = await ValidateUser(credentials)) == null) {
                return new BadRequestObjectResult(new { message = "Login failed" });
            }

            var token = GenerateToken(identityUser);

            return Ok(new { token = token, message = "Login successfully" });
        }

        private async Task<IdentityUser> ValidateUser(Credentials credentials) {

            var userInfo = await userManager.FindByNameAsync(credentials.UserName);

            if(userInfo == null) {
                return null;
            }

            var result = userManager.PasswordHasher.VerifyHashedPassword(userInfo, userInfo.PasswordHash, credentials.Password);

            return result == PasswordVerificationResult.Failed ? null : userInfo;
        }

        public string GenerateToken(IdentityUser identityUser) {

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, identityUser.UserName),
                    new Claim(ClaimTypes.NameIdentifier, identityUser.Id)
                }),
                Audience = jwtTokenSettings.Audience,
                Expires = DateTime.UtcNow.AddSeconds(jwtTokenSettings.ExpiryTimeInSeconds),
                Issuer = jwtTokenSettings.Issuer,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtTokenSettings.SecretKey)),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
