using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Brainstorm.Model.Model;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Brainstorm.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code Field Cannot be empty")]//annotations
        [MaxLength(4, ErrorMessage = "Max length is 4")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Code must be numeric")]
        [Display(Name = "Product Code:")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Cannot be empty")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
        [Display(Name = "Product Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Select a Category")]
        [Display(Name = "Category:")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid")]
        [Display(Name = "Reorder Level:")]
        public int ReorderLevel { get; set; }
        [Display(Name = "Description:")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public List<SelectListItem> CategorySelectListItems { get; set; }
    }
}