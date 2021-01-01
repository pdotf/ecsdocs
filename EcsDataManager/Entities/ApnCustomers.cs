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
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Tell) + " is required.")]
        [MaxLength(500)]
        public string Tell { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Mobile) + " is required.")]
        [MaxLength(4000)]
        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(OwnerTeam) + " is required.")]
        [MaxLength(50)]
        public string OwnerTeam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(WanIpRange) + " is required.")]
        [MaxLength(500)]
        public string WanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AccessList) + " is required.")]
        [MaxLength(500)]
        public string AccessList { get; set; }

        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please enter valid integer Number")]
        [Required]
        public int NumberOfSimCard { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AcountManager) + " is required.")]
        [MaxLength(50)]
        public string AcountManager { get; set; }

        [MaxLength(4000)]
        public string Comment { get; set; }

        //navigation properties

    }
}
