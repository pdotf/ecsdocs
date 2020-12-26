using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcsDataManager.Entities
{
    public class CustomerUrl
    {
        public int id { get; set; }
        public int customerId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Only Url is acceptable to save")]  
        [Url]
        public string link { get; set; }
        public Int16? isMain { get; set; }

    }
}
