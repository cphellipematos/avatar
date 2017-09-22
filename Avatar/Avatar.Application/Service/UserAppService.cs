﻿
using System.Collections.Generic;
using Avatar.Application.Interfaces;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;

namespace Avatar.Application.Service
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }
        public UserViewModel CreateUser(UserViewModel user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserViewModel> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public UserViewModel GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public UserViewModel UpdateUser(UserViewModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}