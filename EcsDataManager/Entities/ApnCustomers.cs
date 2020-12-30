using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcsDataManager.Entities
{
    public class ApnCustomers
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(CustomerName) + " is required.")]
        public string CustomerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Tell) + " is required.")]
        public string Tell { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Mobile) + " is required.")]
        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(OwnerTeam) + " is required.")]
        public string OwnerTeam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(WanIpRange) + " is required.")]
        public string WanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AccessList) + " is required.")]
        public string AccessList { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(NumberOfSimCard) + " is required.")]

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public string NumberOfSimCard { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Comment) + " is required.")]

        public string Comment { get; set; }

        //navigation properties

    }
}
