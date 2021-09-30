using System;
using System.ComponentModel.DataAnnotations;

namespace food.Models
{
    public class fooditem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }
        public string test { get; set; }
        public string type { get; set; }
        public string origin { get; set; }

    }
}
