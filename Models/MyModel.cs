using System;
using System.ComponentModel.DataAnnotations;

namespace crudelicious.Models
{
    public class MyModel
    {
        // auto-implemented properties need to match the columns in your table
        // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
        [Key]
        public int MyModelId { get; set; }
        // MySQL VARCHAR and TEXT types can be represeted by a string
        [Required]
        [Display(Name = "Chef's Name: ")]
        public string chefName { get; set; }
            
        [Required]
        [Display(Name = "Name of Dish: ")]
        public string dishName { get; set; }
        [Required]
        [Display(Name = "# of Calories: ")]
        public string Calories { get; set; }

        [Required]
        [Display(Name = "Tastiness ")]
        public string Tastiness { get; set; }

        [Required]
        [Display(Name = "Description:")]
        public string Description {get; set;}        
        
        // The MySQL DATETIME type can be represented by a DateTime
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}      
    }
}