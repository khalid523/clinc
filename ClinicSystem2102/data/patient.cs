using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace clinicSystem2102.data
{
    [Table("patients")]
    public class patient
    {
        [Required]
        public int ID { set; get; }
        [Required(ErrorMessage = "please fill name")]
        public string Name { set; get; }
        public DateTime BDate { set; get; }

        public string phone { set; get; }
        [ForeignKey("country")]
        public int country_id { set; get; }
        public Country country { set; get; }


    }
}
