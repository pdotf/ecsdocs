using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcsDataManager.Entities
{
    public class DeviceList
    {
        public int Id { get; set; }
        public int VpnCustomerId { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(RadioName) + " is required.")]
        public string RadioName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(RadioIp) + " is required.")]
        public string RadioIp { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(RadioModel) + " is required.")]
        public string RadioModel { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = nameof(RadioMetroSite) + " is required.")]
        public string RadioMetroSite { get; set; }
        public Int16 IsAuto { get; set; }
        public Int16 IsMain { get; set; }

        public string IsAutomatic
        {
            get
            {
                if (IsAuto == 1)
                {
                    return "Auto";
                }
                else
                {
                    return "Manuel";
                }

            }
        }

        public VpnCustomers VpnCustomer { get; set; }
    }
}
