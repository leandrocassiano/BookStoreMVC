using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.ViewModels
{
    public class BookAuthorDetailsViewModel
    {
        [Required(ErrorMessage = "BookId is required.")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "AuthorId is required.")]
        public int AuthorId { get; set; }

    }
}