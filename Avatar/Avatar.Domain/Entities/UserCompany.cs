﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class UserCompany
    {
        #region Constructors
        public UserCompany()
        {

        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public int IdCompany { get; set; }
        public int IdUser { get; set; }

        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        #endregion

    }
}