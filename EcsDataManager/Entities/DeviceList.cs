using System;
using System.Collections.Generic;
using System.Text;

namespace EcsDataManager.Entities
{
    public class DeviceList
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string RadioName { get; set; }
        public string RadioIp { get; set; }
        public string RadioModel { get; set; }
        public string RadioMetroSite { get; set; }
        public Int16 IsAuto { get; set; }
        public Int16 IsMain { get; set; }
    }
}
