﻿using System.ComponentModel.DataAnnotations;

namespace NewTech.ProjectsNG.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
