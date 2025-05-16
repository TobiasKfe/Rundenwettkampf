using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rundenwettkampf.Models
{
    internal class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int No { get; set; }
        //ClubId
    }
}
