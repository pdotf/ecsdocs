using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace EcsDataManager.Entities
{
    public class Customers
    {

        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(CustomerName) + " is required.")][MaxLength(50)]
        public string CustomerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Tel) + " is required.")][MaxLength(500)]
        public string Tel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Mobile) + " is required.")]
        [MaxLength(4000)]
        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(OwnerTeam) + " is required.")]
        [MaxLength(50)]
        public string OwnerTeam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(ServiceType) + " is required.")]
        [MaxLength(50)]
        public string ServiceType { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(ServiceTopology) + " is required.")]
        [MaxLength(50)]
        public string ServiceTopology { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AccountManager) + " is required.")]
        [MaxLength(50)]
        public string AccountManager { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(IpHQ) + " is required.")]
        [MaxLength(100)]
        public string IpHQ { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AAAGroup) + " is required.")]
        [MaxLength(100)]
        public string AAAGroup { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(IpTunnel) + " is required.")]
        [MaxLength(500)]
        public string IpTunnel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(WanIpRange) + " is required.")]
        [MaxLength(500)]
        public string WanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(LanIpRange) + " is required.")]
        [MaxLength(200)]
        public string LanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(VRF) + " is required.")]
        [MaxLength(200)]
        public string VRF { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(VpnToolsName) + " is required.")]
        [MaxLength(100)]
        public string VpnToolsName { get; set; }
       [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AccessList) + " is required.")]
        [MaxLength(100)]
public string AccessList { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(APN) + " is required.")]
        [MaxLength(100)]
        public string APN { get; set; }

        public string Comment { get; set; }

        





    }
}
