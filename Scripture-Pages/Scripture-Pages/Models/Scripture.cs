using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scripture_Pages.Models
{
    public class Scripture
    {
       public int id { get; set; } 
    public String note { get; set; }
       public String book { get; set; }
        public int chapter { get; set; }
        public int verse { get; set; }
        public string standardWork { get; set; }
        [DataType(DataType.Date)]
        public DateTime datePosted { get; set; }
    }
}
