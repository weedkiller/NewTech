﻿using System.ComponentModel.DataAnnotations;

namespace NewTech.ProjectsNG.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}