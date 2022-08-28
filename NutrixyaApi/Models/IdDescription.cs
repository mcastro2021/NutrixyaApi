using System.ComponentModel.DataAnnotations;

namespace NutrixyaApi.Models
{
    public class IdDescription
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
