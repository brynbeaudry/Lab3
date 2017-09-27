using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int Population { get; set; }
        public string ProvinceCode { get; set; }
    }
}