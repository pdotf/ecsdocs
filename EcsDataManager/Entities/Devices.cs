using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Entities
{
    public class Devices
    {

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string RadioMainName { get; set; }
        public string RadioMainIp { get; set; }

        public string RadioMainModel { get; set; }
        public string RadioMainMetroSite { get; set; }
        public string RadioBackupName { get; set; }

        public string RadioBackupIp { get; set; }

        public string RadioBackupModel { get; set; }

        public string RadioBackupMetroSite { get; set; }


        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a number")]
        [Display(Name = "Oxygen")]
        [RegularExpression(@"^\d+$")]
        [Required(ErrorMessage = "{0} is required")]
        [Range(0, 30, ErrorMessage = "Please use values between 0 to 30")]
        public string BackupActivationIsAuto { get; set; }


        //       [Id] [int] IDENTITY(1,1) NOT NULL,
        //[CustomerId] [int] NOT NULL,
        //[RadioMainName] [nvarchar](50) NULL,
        //[RadioMainIp] [nvarchar](50) NULL,
        //[RadioMainModel] [nvarchar](50) NULL,
        //[RadioMainMetroSite] [nvarchar](50) NULL,
        //[RadioBackupName] [nvarchar](50) NULL,
        //[RadioBackupIp] [nvarchar](50) NULL,
        //[RadioBackupModel] [nvarchar](50) NULL,
        //[RadioBackupMetroSite] [nvarchar](50) NULL,
        //[BackupActivationIsAuto] [tinyint] NULL,
    }
}
