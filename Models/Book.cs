using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Racoti_DianaOctavia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Completați titlul cărții!")]
        [MaxLength(150, ErrorMessage = "Titlul cărții nu poate avea mai mult de 150 de caractere.")]
        [MinLength(3, ErrorMessage = "Titlul cărții trebuie să aibă cel puțin 3 caractere.")]
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }//navigation property

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
        //public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    } 
}

