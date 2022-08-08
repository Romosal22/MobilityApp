using Microsoft.AspNetCore.Identity;
using MobilityRentApp_Backend.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace MobilityRentApp_Backend.Model.Entities
{
    public class Role : IHasId
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Name { get; set; }


    }
}
