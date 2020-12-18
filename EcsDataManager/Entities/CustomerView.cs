using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Entities
{
    public class CustomerView
    {
        //a.id,CustomerName,Tel,Mobile,OwnerTeam,ServiceType,ServiceTopology,AccountManager,IpHQ,AAAGroup,IpTunnel,WanIpRange,LanIpRange,VRF,VpnToolsName,APN,Comment,CustomerId,RadioMainName,RadioMainIp,RadioMainModel,RadioMainMetroSite,RadioBackupName,RadioBackupIp,RadioBackupModel,RadioBackupMetroSite,BackupActivationIsAuto
        public int Id { get; set; }
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

        public virtual ICollection<Devices> Deviceses { get; set; } = new HashSet<Devices>();


        //public List<Devices> Devices { get; set; }
        //public int CustomerId { get; set; }
        //public string? RadioMainName { get; set; }
        //public string? RadioMainIp { get; set; }
        //public string? RadioMainModel { get; set; }
        //public string? RadioMainMetroSite { get; set; }
        //public string? RadioBackupName { get; set; }
        //public string? RadioBackupIp { get; set; }
        //public string? RadioBackupModel { get; set; }
        //public string? RadioBackupMetroSite { get; set; }
        //public int BackupActivationIsAuto { get; set; }


    }
}
