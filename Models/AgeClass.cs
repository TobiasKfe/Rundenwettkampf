using System.ComponentModel.DataAnnotations;
using Rundenwettkampf.utils;

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
        public AgeClassType Type { get; set; }
    }
}
