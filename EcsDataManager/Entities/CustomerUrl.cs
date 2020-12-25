using System;
using System.Collections.Generic;
using System.Text;

namespace EcsDataManager.Entities
{
    public class CustomerUrl
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public string link { get; set; }
        public Int16 isMain { get; set; }

    }
}
