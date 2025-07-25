﻿using Microsoft.EntityFrameworkCore;
using Mission.Entities;
using Mission.Entities.ViewModels.Login;
using Mission.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.Repository
{
    public class UserRepository(MissionDbContext dbContext) : IUserRepository
    {
        private readonly MissionDbContext _context = dbContext;

        public async Task<(UserLoginResponseModel? response, string message)> LogiUser(UserLoginRequestModel model)
        {
            var user = await _context.Users.Where(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower()).FirstOrDefaultAsync();
            if (user == null)
            {
                return (null, "user doesn't exist for the given emailaddress");
            }
            if (user.Password != model.Password)
            {
                return (null, "Password Doesn't match");

            }
            var response = new UserLoginResponseModel()
            {
                Id = user.Id,
                EmailAddress = user.EmailAddress,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                UserType = user.UserType,
                UserImage = user.UserImage
            };

            return (response, "Login Successful");
        }
    }
}
