using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Models
{
    public class CustomersModel
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string CustomerName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string Tel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string Mobile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string OwnerTeam { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string ServiceType { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string ServiceTopology { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string AccountManager { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string IpHQ { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string AAAGroup { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string IpTunnel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string WanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string LanIpRange { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string VRF { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " * required field.")]
        public string VpnToolsName { get; set; }
        public string RadioMainName { get; set; }
        public string RadioMainIp { get; set; }
        public string RadioMainModel { get; set; }
        public string RadioMainMetroSite { get; set; }
        public string RadioBackupName { get; set; }
        public string RadioBackupIp { get; set; }
        public string RadioBackupModel { get; set; }
        public string RadioBackupMetroSite { get; set; }
        public int BackupActivationIsAuto { get; set; }
        public string Comment { get; set; }
    }
}
