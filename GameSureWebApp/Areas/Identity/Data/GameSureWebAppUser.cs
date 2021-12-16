using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace GameSureWebApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the GameSureWebAppUser class
    public class GameSureWebAppUser : IdentityUser
    {   
        [PersonalData]
        [Required]
        [Column(TypeName ="Text")]
        public string FirstName { get; set; }
        
        [PersonalData]
        [Required]
        [Column(TypeName = "Text")] 
        public string LastName { get; set; }
        [PersonalData]
        [Required]
        public int Phone { get; set; }
        
    }
}
