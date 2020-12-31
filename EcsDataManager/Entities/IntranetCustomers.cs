using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcsDataManager.Entities
{
    public class IntranetCustomers
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
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(ServiceType) + " is required.")]
        [MaxLength(10)]
        public string ServiceType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(IpRange) + " is required.")]
        [MaxLength(500)]
        public string IpRange { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Comment) + " is required.")]

        [MaxLength(4000)]
        public string Comment { get; set; }
    }
}
