﻿using System.ComponentModel.DataAnnotations;

namespace InventoryBeginners.Models
{
    public class Brand
    {

        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Description { get; set; }

    }
}
