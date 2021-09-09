using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace server.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        [ForeignKey("Blog")]
        // [JsonIgnore]
        public int BlogIdFk { get; set; }
        // [JsonIgnore]
        public Blog Blog { get; set; }
    }
}
