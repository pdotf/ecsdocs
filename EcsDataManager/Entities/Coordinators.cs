using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcsDataManager.Entities
{
    public class Coordinators
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string TaName { get; set; }
        [MaxLength(200)]
        public string Tell { get; set; }
        [MaxLength(200)]
        public string Mobile { get; set; }
        
        [MaxLength(50)]
        public string AHDTracker { get; set; }
        [MaxLength(4000)]
        public string Comment { get; set; }

    }
}
