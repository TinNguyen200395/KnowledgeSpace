﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeSpace.API.Data.Entities
{
    [Table("Users")]
    public class User : IdentityUser
    {
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        public int? NumberOfKnowledgeBases { get; set; }

        public int? NumberOfVotes { get; set; }

        public int? NumberOfReports { get; set; }
    }
}