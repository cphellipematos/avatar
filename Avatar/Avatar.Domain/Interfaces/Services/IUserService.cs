﻿using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        void DeleteUser(int id);
        void GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetAllUserCompaniesByUserId(int userId);
        IEnumerable<User> GetAllUserCoursesByUserId(int userId);
        void UpdateUser();
    }
}
