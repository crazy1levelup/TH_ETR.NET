using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TopHatFamDoc.Models;

namespace TopHatFamDoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly AuthenticationContext _context;

        public UserProfileController(UserManager<ApplicationUser> userManager, AuthenticationContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        //GET: /api/UserProfile
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.Nume,
                user.Prenume,
                user.ZiuaNastere,
                user.DataInregistrare,
                user.Notes

            };

        }

        [HttpPut]
        [Authorize]
        //PUT: /api/UserProfile
        public async Task<Object> PutUserProfile([FromBody] ApplicationUserModel userProfile)
        {   
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            user.Notes = userProfile.Notes;
            await _context.SaveChangesAsync();
            return new
            {
                user.Nume,
                user.Prenume,
                user.ZiuaNastere,
                user.DataInregistrare,
                user.Notes,

            };

        }
    }
}