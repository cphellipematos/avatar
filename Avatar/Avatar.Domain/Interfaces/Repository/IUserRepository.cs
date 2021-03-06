﻿using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllUserCompaniesByUserId(int userId);
        IEnumerable<User> GetAllUserCoursesByUserId(int userId);
        User GetUserByEmail(string email);
    }


}
