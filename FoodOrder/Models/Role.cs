﻿using Microsoft.AspNetCore.Identity;

namespace FoodOrder.Models
{
    public class Role : IdentityRole<int>
    {
        public string Description { get; set; }


    }
}
