using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class UpdateBookViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="**")]
        [Display(Name ="Nome do Livro")]
        public string Title { get; set; }
       
        [Required(ErrorMessage = "**")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }
        
        [Required(ErrorMessage = "**")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
       
        [Required(ErrorMessage = "**")]
        public int CategoryId { get; set; }
        public SelectList CategoryOptions { get; set; }
    }
}