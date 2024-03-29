﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourse.Video.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AvatarPath { get; set; }
        public Subscription SubscriptionType { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }

        public ICollection<Role> Roles { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}