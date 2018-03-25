﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AprioritWebCalendar.Business.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public IEnumerable<string> Roles { get; set; } = new List<string>();
    }
}
