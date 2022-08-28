using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NutrixyaApi.Models
{
    public class Lot
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        [Column("hectares_quantity")]
        public int HectaresQuantity { get; set; }

        [Column("field_stablishment")]
        public string? FieldStablishment { get; set; }

        [Column("city_id")]
        public int CityId { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }


        [Column("user_id")]
        public int UserId { get; set; }

        [Column("status_id")]
        public int StatusId { get; set; }

    }

}
