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
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Tel) + " is required.")]
        public string Tel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(Mobile) + " is required.")]
        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(OwnerTeam) + " is required.")]
        public string OwnerTeam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(ServiceType) + " is required.")]
        public string ServiceType { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(ServiceTopology) + " is required.")]
        public string ServiceTopology { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AccountManager) + " is required.")]
        public string AccountManager { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(IpHQ) + " is required.")]
        public string IpHQ { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(AAAGroup) + " is required.")]
        public string AAAGroup { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(IpTunnel) + " is required.")]
        public string IpTunnel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(WanIpRange) + " is required.")]
        public string WanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(LanIpRange) + " is required.")]
        public string LanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(VRF) + " is required.")]
        public string VRF { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(VpnToolsName) + " is required.")]
        public string VpnToolsName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(APN) + " is required.")]

        public string APN { get; set; }

        public string Comment { get; set; }

        //navigation properties
        public ICollection<ApnDevices> ApnDevices { get; set; }

        public ApnUrl ApnUrl { get; set; }
    }
}
