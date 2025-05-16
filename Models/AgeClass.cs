using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rundenwettkampf.Models
{
    internal class AgeClass
    {
        [Key]
        public int Id { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string Title { get; set; }
        public int No { get; set; }
        public bool IsLaid { get; set; }
    }
}
