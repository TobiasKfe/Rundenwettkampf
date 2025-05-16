using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rundenwettkampf.Models
{
    internal class League
    {
        [Key]
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
    }
}
