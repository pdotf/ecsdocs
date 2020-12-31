﻿using System;
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
        [MaxLength(500)]
        public string Tell { get; set; }
        [MaxLength(50)]
        public string Coordinator { get; set; }
        [MaxLength(4000)]
        public string Comment { get; set; }

    }
}