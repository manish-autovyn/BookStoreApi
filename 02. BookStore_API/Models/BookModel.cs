using System.ComponentModel.DataAnnotations;

namespace _02._BookStore_API.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add title !")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
