﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public int UserTypeId { get; set; }
        public string UserName { get; set; }
    }
}
