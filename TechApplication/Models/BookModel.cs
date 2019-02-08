using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechApplication.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required]
        [Remote("NameValid", "BookModels", ErrorMessage = "Такой расчет уже существует")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Автор")]
        public string Author { get; set; }
        public int Year { get; set; }
    }

}