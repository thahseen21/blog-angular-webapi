using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        [ForeignKey("Blog")]
        public int BlogIdFk { get; set; }
        public Blog Blog { get; set; }
    }
}
