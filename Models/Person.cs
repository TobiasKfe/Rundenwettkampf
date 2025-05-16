using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rundenwettkampf.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public int StartNo { get; set; }
        public string Gender { get; set; }
        public string Handicap { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        
        //ClubNo
        //AgeClassNo
        //LaidAgeClassNo
    }
}
