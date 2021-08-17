
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hive.Backend.DataModels;
using Hive.Backend.Models;

namespace Hive.Backend.ViewModels
{
    public partial class UserVM
    {
        public UserVM()
        {
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public string UserProfileId { get; set; }

        [Timestamp]
        public byte[] RawVersion { get; set; }

    }
}