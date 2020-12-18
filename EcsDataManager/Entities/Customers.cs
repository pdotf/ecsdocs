using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Entities
{
    public class Customers
    {

        [Key]
        public int id { get; set; }

        public string CustomerName { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string OwnerTeam { get; set; }
        public string ServiceType { get; set; }
        public string ServiceTopology { get; set; }
        public string AccountManager { get; set; }
        public string IpHQ { get; set; }
        public string AAAGroup { get; set; }
        public string IpTunnel { get; set; }
        public string WanIpRange { get; set; }
        public string LanIpRange { get; set; }
        public string VRF { get; set; }
        public string VpnToolsName { get; set; }

        public string APN { get; set; }

        public string Comment { get; set; }

        public int RowNumber { get; set; }
    }
}
