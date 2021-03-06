﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FoodChooser.Models
{
    public class FoodItem
    {
        [Key]
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public FoodList FoodList { get; set; }
        public Guid FoodListId { get; set; }
        public DateTime Created { get; set; }
        public bool IsPublic { get; set; }
        public string ImageString { get; set; }
    }
}
