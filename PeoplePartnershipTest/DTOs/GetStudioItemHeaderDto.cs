﻿using System.ComponentModel.DataAnnotations;

namespace PeoplePartnershipTest.DTOs
{
    public class GetStudioItemHeaderDto
    {
        public int StudioItemId { get; set; }      
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }        

        
    }
}
