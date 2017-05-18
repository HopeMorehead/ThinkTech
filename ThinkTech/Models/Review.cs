using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThinkTech.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public string ConsumerRatingNumber { get; set; }
        public string FunctionalityImprovements { get; set; }
        public string ConsumerReport { get; set; }


        //Foreign Key
        public int CategoryId{ get; set; }
        // Navigation property
        public  Category Category { get; set; }

        
    }
}