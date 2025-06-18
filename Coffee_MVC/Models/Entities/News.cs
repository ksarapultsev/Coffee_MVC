using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_MVC.Models.Entities
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Desciption { get; set; }

        public string AuthorId { get; set; }
        public IdentityUser Author { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }


    }
}
