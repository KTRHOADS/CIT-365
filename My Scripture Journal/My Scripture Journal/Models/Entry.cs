using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My_Scripture_Journal.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string StandardWork { get; set; }

        [DataType(DataType.Date)]
        public String datePosted = DateTime.Now.ToString("MM/dd/yyyy");
        public string Book { get; set; }
        public int Chapter { get; set; }
        public String Verses { get; set; }
        public String Note { get; set; }
        public String Passage { get; set; }

        public String DatePosted { get => datePosted; set => datePosted = value; }
    }
}
