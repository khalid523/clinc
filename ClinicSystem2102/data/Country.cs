using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace clinicSystem2102.data
{
    [Table("countries")]
    public class Country
    {

         public int Id { set; get; }
        [Required(ErrorMessage ="please fill name")]
         public string Name { set; get; }
        public List<patient> Lipatient { set; get; }
    }
}
