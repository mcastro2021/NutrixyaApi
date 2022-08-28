using System.ComponentModel.DataAnnotations.Schema;

namespace NutrixyaApi.Models
{
    public class Province:IdDescription
    {
        [Column("Country_Id")]
        public int CountryId { get; set; }
    }
}
